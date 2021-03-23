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
    public Window() {
      InitializeComponent();
    }

    // Double-buffering
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
