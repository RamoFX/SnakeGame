using System;
using System.Windows.Forms;

using SnakeGame.Modules.Helpers;



namespace SnakeGame.Modules.Core {
  class Loop {
    public readonly Timer Timer;

    public Loop() {
      this.Timer = new Timer {
        Interval = 1000 / Storage.Preferences.FramesPerSecond
      };
      this.Timer.Tick += this.GameTick;
    }

    public void GameTick(object sender, EventArgs e) {
      // Fire frame render
      Storage.Controls.Find("Panel_Arena", true)[0].Invalidate();
    }
  }
}
