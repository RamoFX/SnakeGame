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
    private void Panel_GameField_Paint(object sender, PaintEventArgs e) {
      // Grid
      Size fs = GameField.Size;
      Size fsu = Scaling.Unscale(fs);
      Pen pen = new Pen(Color.FromArgb(255, 35, 35, 35), 2);

      for (int i = 0; i < fsu.Width; i++) {
        e.Graphics.DrawLine(pen, i * CellSize - 1, -1, i * CellSize, fs.Height);

        for (int j = 0; j < fsu.Height; j++) {
          e.Graphics.DrawLine(pen, -1, j * CellSize - 1, fs.Width, j * CellSize);
        }
      }

      // Elements
      Drawing.Draw(e.Graphics, snake.Parts);
      Drawing.Draw(e.Graphics, food);
    }
  }
}
