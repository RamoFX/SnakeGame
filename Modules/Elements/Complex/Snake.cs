using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using SnakeGame.Modules.Core;
using SnakeGame.Modules.Core.Actions;
using SnakeGame.Modules.Elements.Base;
using SnakeGame.Modules.Elements.Simple;
using SnakeGame.Modules.Extensions;
using SnakeGame.Modules.Helpers;



namespace SnakeGame.Modules.Elements.Complex {
  class Snake {
    public Positioning.Direction CurrentDirection;
    public Positioning.Direction NextDirection;

    public List<SnakeSegment> Segments;
    public readonly Brush Brush;

    private int _FoodEatenCount = 0;

    public int FoodEatenCount {
      get { return this._FoodEatenCount; }

      set {
        this._FoodEatenCount = value;
        this.Speed = CalculateSpeed();
        if (this.LifecycleTimer != null)
          this.LifecycleTimer.Interval = CalculateLifecycleInterval();
      }
    }

    public int Speed;

    public bool Alive;

    public readonly Timer LifecycleTimer;

    public readonly string PlayerId;

    public Player CurrentPlayer {
      get {
        return Storage.Runtime.Players.Single(player => player.Id == this.PlayerId);
      }
    }

    public Player EnemyPlayer {
      get {
        return Storage.Runtime.Players.Single(player => player.Id != this.PlayerId);
      }
    }



    public Snake(Point initialLocation, Positioning.Direction initialDirection, Brush brush, string playerId) {
      CurrentDirection = initialDirection;
      NextDirection = initialDirection;

      this.Brush = brush;

      this.Segments = new();
      Segments.Add(new(initialLocation, this.Brush));

      this.FoodEatenCount = 0;
      this.Speed = this.CalculateSpeed();

      this.Alive = true;

      this.LifecycleTimer = new() {
        Interval = CalculateLifecycleInterval()
      };
      this.LifecycleTimer.Tick += this.LifecycleTick;

      this.PlayerId = playerId;
    }



    // Lifecycle
    private void LifecycleTick(object sender, EventArgs e) {
      if (this.Alive) {
        // Motion
        this.CurrentDirection = this.NextDirection;
        this.Move();

        // Check food collision
        if (this.DoesCollideWith(this.CurrentPlayer.Food)) {
          this.CurrentPlayer.Food.Relocate();
          this.FoodEatenCount++;
          SnakeAteFood.Fire(this.CurrentPlayer);
        } else if (this.DoesCollideWith(this.EnemyPlayer.Food)) {
          this.EnemyPlayer.Food.Relocate();
          this.ShortenSnake(1 + 1 /* <-- move compensation */);
        } else {
          this.ShortenSnake(0 + 1 /* <-- move compensation */);
        }

        // Check player collision
        if (DoesCollideWithOneOf(this.Segments.SkipWhile(segment => segment == this.Segments[0]))) {
          this.ShortenSnake(this.Segments.Count - this.Segments.FindLastIndex(DoesCollideWith));
        } else if (DoesCollideWith(this.EnemyPlayer.Snake)) {
          SnakeDie.Fire(this.CurrentPlayer);
        }
      }
    }



    // Actions
    public void Move() {
      if (this.Segments.Count > 0) {
        this.Segments = this.Segments.Prepend(this.Segments[^1]).ToList();

        int[] computedMoveCoordinatesCoefficients = CalculateMoveCoordinatesCoefficients();
        int[] arenaDimensions = Storage.Preferences.ArenaSize.ToArray();

        this.Segments[0] = new(
          this.Segments[1].Location.GetModified((coordinate, idx) => ( arenaDimensions[idx] + coordinate + computedMoveCoordinatesCoefficients[idx] ) % arenaDimensions[idx]),
          this.Brush
        );
      }
    }

    public void ShortenSnake(int cellsCount) {
      if (cellsCount >= this.Segments.Count) {
        SnakeDie.Fire(this.CurrentPlayer);
      } else {
        this.Segments = this.Segments.Where((_, idx) => idx < this.Segments.Count - cellsCount).ToList();
      }
    }



    // Collision
    private bool DoesCollideWith(Element element) {
      if (this.Segments.Count > 0) {
        return this.Segments[0].Location == element.Location;
      } else {
        return false;
      }
    }

    private bool DoesCollideWithOneOf(IEnumerable<Element> elements) {
      return elements.Any(DoesCollideWith);
    }

    private bool DoesCollideWith(Snake snake) {
      return DoesCollideWithOneOf(snake.Segments);
    }



    // Calculation
    private int CalculateSpeed() {
      return 3 + (int) Math.Floor((decimal) ( this.FoodEatenCount / Storage.Preferences.GrowPerFood.Item2 )) * Storage.Preferences.GrowPerFood.Item1;
    }

    private int CalculateLifecycleInterval() {
      return 1000 / this.Speed;
    }

    private int[] CalculateMoveCoordinatesCoefficients() {
      int[] coordinatesCoefficients = new int[2] { 0, 0 };

      for (int idx = 0; idx < Enum.GetValues(typeof(Positioning.Direction)).Length; idx++) {
        if ((int) this.CurrentDirection == idx)
          coordinatesCoefficients[idx / 2] = idx % 2 == 1 ? 1 : -1;
      }

      return coordinatesCoefficients.Reverse().ToArray();
    }
  }
}
