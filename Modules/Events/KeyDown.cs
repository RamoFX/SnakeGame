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
    private void Window_KeyDown(object sender, KeyEventArgs e) {
      // Set snake's direction
      Keys pressedKey = e.KeyCode;

      Keys[][] keys = new Keys[][] {
        new Keys[] { Keys.W, Keys.Up },
        new Keys[] { Keys.S, Keys.Down },
        new Keys[] { Keys.A, Keys.Left },
        new Keys[] { Keys.D, Keys.Right }
      };

      for (int i = 0; i < keys.Length; i++) {
        Keys[] currentKeys = keys[i];
        Positioning.Direction possiblyNextDirection = (Positioning.Direction) i;
        bool validMoveKey = currentKeys.Contains(pressedKey);
        bool notOppositeKey = Positioning.OppositeDirection(possiblyNextDirection) != snake.CurrentDirection;

        if (validMoveKey && notOppositeKey)
          snake.NextDirection = possiblyNextDirection;
      }

      // Start game
      if (GameState == GameStates.ToBeStarted) {
        GameState = GameStates.Started;
      }
    }
  }
}
