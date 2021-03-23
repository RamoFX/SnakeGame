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
    private void Window_Load(object sender, EventArgs e) {
      GameField = Panel_GameField;
      Score = Label_Score;
      PressToStart = Label_PressToStart;

      InitializeTimer();

      snake = new Snake(Positioning.Center());
      food = new Food(Positioning.Center(0, -3));

      StartTimer();
    }
  }
}
