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
    private void Window_Tick(object sender, EventArgs e) {
      Window_Tick_Pre();

      if(GameState == GameStates.ToBeStarted)
        Window_Tick_ToBeStarted();

      else if (GameState == GameStates.Started)
        Window_Tick_Started();

      else
        Window_Tick_Ended();

      Window_Tick_Post();
    }
  }
}
