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
    class Dialogs {
      public static void ShowLoseMessage() {
        string[] possibleMessages = new string[] {
          "Not bad!",
          "Keep going!",
          "Maybe next time!"
        };

        MessageBox.Show($"{ possibleMessages[Random.Next(possibleMessages.Length)] }\nYour score is: { FoodEatenCount * 10 }", "You'll do better next time!");
      }
      public static void ShowWinMessage() {
        string[] possibleMessages = new string[] {
          "Who is the winner? You are the winner!",
          "Awesome result!"
        };

        MessageBox.Show(possibleMessages[Random.Next(possibleMessages.Length)], "Congratulations");
      }

      public static void AskForNewGame() {
        DialogResult dialogResult = MessageBox.Show(
          "Would you like to start new game?",
          "Another one?",
          MessageBoxButtons.YesNo
        );

        if(dialogResult == DialogResult.Yes) {
          Application.Restart();
        } else {
          Application.Exit();
        }
      }
    }
  }
}
