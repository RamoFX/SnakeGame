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
    private void InitializeTimer() {
      UpdateTimerInterval();
      Timer.Tick += Window_Tick;
    }

    private static void UpdateTimerInterval() {
      Timer.Interval = 1000 / Speed;
    }

    private void StartTimer() {
      Timer.Start();
    }
  }
}
