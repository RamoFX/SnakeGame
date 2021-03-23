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
    private void Window_Tick_Ended() {
      Timer.Stop();

      if (FoodEatenCount == 17 * 17) {
        Dialogs.ShowWinMessage();
      } else {
        Dialogs.ShowLoseMessage();
      }

      Dialogs.AskForNewGame();
    }
  }
}
