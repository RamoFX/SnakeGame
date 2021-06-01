using System.Drawing;
using System.Collections.Generic;

using SnakeGame.Modules.Core;
using SnakeGame.Modules.Elements.Base;
using SnakeGame.Modules.Elements.Complex;
using SnakeGame.Modules.Helpers;



namespace SnakeGame.Modules.Elements.Simple {
  class Food : Element {
    public Food(Point initialLocation, Brush brush) : base(initialLocation, new(1, 1), true, brush) {

    }

    public void Relocate() {
      List<Point> excludePoints = new();

      foreach (Player player in Storage.Runtime.Players) {
        excludePoints.Add(player.Food.Location);
        
        foreach (SnakeSegment snakeBodyCell in player.Snake.Segments) {
          excludePoints.Add(snakeBodyCell.Location);
        }
      }

      this.Location = Positioning.Random(excludePoints);
    }
  }
}
