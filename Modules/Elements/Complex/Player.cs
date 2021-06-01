using System.Drawing;

using SnakeGame.Modules.Elements.Simple;
using SnakeGame.Modules.Helpers;



namespace SnakeGame.Modules.Elements.Complex {
  class Player {
    public readonly string Name;
    public readonly string Id;

    public readonly Food Food;
    public readonly Snake Snake;

    public Player(
      string name, string id,
      Point foodInitialLocation, Brush foodBrush,
      Point snakeInitialLocation, Positioning.Direction snakeInitialDirection, Brush snakeBrush
    ) {
      this.Name = name;
      this.Id = id;

      this.Food = new(foodInitialLocation, foodBrush);
      this.Snake = new(snakeInitialLocation, snakeInitialDirection, snakeBrush, this.Id);
    }
  }
}
