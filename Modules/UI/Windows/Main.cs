using System;
using System.Drawing;
using System.Windows.Forms;

using SnakeGame.Modules.Core;
using SnakeGame.Modules.Elements.Complex;
using SnakeGame.Modules.Helpers;



namespace SnakeGame.Modules.UI.Windows {
  public partial class Main : Form {
    public Main() {
      InitializeComponent();

      // Initialize storage items
      Storage.Graphics    = Panel_Arena.CreateGraphics();
      Storage.Controls    = this.Controls;

      Storage.Preferences = new Preferences();
      Storage.Runtime     = new Runtime();
      Storage.Loop        = new Loop();

      Storage.Random      = new Random();

      // Start game loop
      Storage.Loop.Start();
    }

    private void Main_KeyDown(object sender, KeyEventArgs e) {
      Keyboard.KeyDown(e);
    }

    private void Panel_Arena_Paint(object sender, PaintEventArgs e) {
      // Grid
      int rowsCount = Storage.Preferences.ArenaSize.Height;
      int columnsCount = Storage.Preferences.ArenaSize.Width;
      Pen gridPen = new(Color.FromArgb(37, 37, 37), 1);

      for (int rowIndex = 0; rowIndex < rowsCount; rowIndex++) {
        e.Graphics.DrawLine(
          gridPen,
          0, rowIndex * Storage.Preferences.ScaleFactor,
          Storage.Preferences.ArenaSize.Width * Storage.Preferences.ScaleFactor, rowIndex * Storage.Preferences.ScaleFactor
       );
      }

      for (int columnIndex = 0; columnIndex < columnsCount; columnIndex++) {
        e.Graphics.DrawLine(
          gridPen,
          columnIndex * Storage.Preferences.ScaleFactor, 0,
          columnIndex * Storage.Preferences.ScaleFactor, Storage.Preferences.ArenaSize.Height * Storage.Preferences.ScaleFactor
       );
      }

      // Players
      foreach (Player player in Storage.Runtime.Players) {
        Drawer.Draw(e.Graphics, player.Food);
        Drawer.Draw(e.Graphics, player.Snake.Segments);
      }
    }

    // Double buffering
    protected override CreateParams CreateParams {
      get {
        var param = base.CreateParams;
        param.ExStyle &= ~0x02000000; // Turn off WS_CLIPCHILDREN
        param.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
        return param;
      }
    }
  }
}
