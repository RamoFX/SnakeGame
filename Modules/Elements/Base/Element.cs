using System.Drawing;



namespace SnakeGame.Modules.Elements.Base {
  class Element {
    public Rectangle Rectangle;
    public bool IsEllipse;
    public Brush Brush;

    public Point Location {
      get { return this.Rectangle.Location; }
      set { this.Rectangle.Location = value; }
    }

    public Size Size {
      get { return this.Rectangle.Size; }
      set { this.Rectangle.Size = value; }
    }

    public Element(Point location, Size size, bool isEllipse, Brush brush) {
      this.Rectangle = new(location, size);
      this.IsEllipse = isEllipse;
      this.Brush = brush;
    }
  }
}
