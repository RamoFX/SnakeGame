using SnakeGame.Modules.Elements.Complex;
using SnakeGame.Modules.Helpers;



namespace SnakeGame.Modules.Core.Actions {
  class GameStart {
    public static void Fire() {
      Storage.Runtime.GameState = GameStates.Playing;

      Storage.Controls.Find("Label_PressToStart", true)[0].Visible = false;

      foreach (Player player in Storage.Runtime.Players) {
        player.Snake.LifecycleTimer.Enabled = true;
      }
    }
  }
}
