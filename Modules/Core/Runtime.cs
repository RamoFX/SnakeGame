using System.Drawing;

using SnakeGame.Modules.Elements.Complex;
using SnakeGame.Modules.Extensions;
using SnakeGame.Modules.Helpers;



namespace SnakeGame.Modules.Core {
  class Runtime {
    public GameStates GameState;
    public readonly Player[] Players;

    public Runtime() {
      this.GameState = GameStates.Awaiting;

      this.Players = new Player[2] {
        new(
          "Blue",
          "player1",

          // Food
          Storage.Preferences.ArenaSize.GetCenter().GetOffset(new Point(-5, -2)),
          Brushes.DarkBlue,

          // Snake
          Storage.Preferences.ArenaSize.GetCenter().GetOffset(new Point(-5, 2)),
          Positioning.Direction.Up,
          Brushes.Blue
        ),
        new(
          "Red",
          "player2",

          // Food
          Storage.Preferences.ArenaSize.GetCenter().GetOffset(new Point(5, 2)),
          Brushes.DarkRed,

          // Snake
          Storage.Preferences.ArenaSize.GetCenter().GetOffset(new Point(5, -2)),
          Positioning.Direction.Down,
          Brushes.Red
        )
      };
    }
  }
}
