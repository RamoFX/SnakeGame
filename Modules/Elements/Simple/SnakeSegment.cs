using System.Drawing;

using SnakeGame.Modules.Elements.Base;



namespace SnakeGame.Modules.Elements.Simple {
  class SnakeSegment : Element {
    public SnakeSegment(Point location, Brush brush) : base(location, new(1, 1), false, brush) {

    }
  }
}
