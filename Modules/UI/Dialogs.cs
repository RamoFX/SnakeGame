using System.Windows.Forms;

using SnakeGame.Modules.Elements.Complex;



namespace SnakeGame.Modules.UI {
  static class Dialogs {
    public static void GameWon(Player winner) {
      MessageBox.Show($"{ winner.Name } is the winner! Congratulations!", "And the winner is...");
    }

    public static void AskForNewGame() {
      DialogResult dialogResult = MessageBox.Show(
        "Would you like to start a new game?",
        "Another one?",
        MessageBoxButtons.YesNo
      );

      if (dialogResult == DialogResult.Yes) {
        Application.Restart();
      } else {
        Application.Exit();
      }
    }
  }
}
