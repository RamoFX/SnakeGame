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
    class Food : Element {
      public Food(Point point) : base(
        Brushes.SeaGreen,
        point,
        new Size(1, 1)
      ) {}
    }
  }
}
