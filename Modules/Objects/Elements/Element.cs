using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake {
  public partial class Window : Form {
    abstract class Element {
      public Brush Brush;
      public Point Location;
      public Size Size;
      public Rectangle Rectangle;

      public Element(Brush brush, Point location, Size size) {
        this.Brush = brush;
        this.Location = location;
        this.Size = size;
        this.Rectangle = new Rectangle(location, size);
      }
    }
  }
}
