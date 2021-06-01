using SnakeGame.Modules.Elements.Complex;
using SnakeGame.Modules.Helpers;
using SnakeGame.Modules.UI;



namespace SnakeGame.Modules.Core.Actions {
  class GameEnd {
    public static void Fire(Player winner) {
      Storage.Runtime.GameState = GameStates.Ended;

      foreach (Player player in Storage.Runtime.Players) {
        player.Snake.Alive = false;
      }

      Dialogs.GameWon(winner);
      Dialogs.AskForNewGame();
    }
  }
}
