using SnakeGame.Modules.Elements.Complex;



namespace SnakeGame.Modules.Core.Actions {
  class SnakeDie {
    public static void Fire(Player looser) {
      looser.Snake.Segments = new();

      Actions.GameEnd.Fire(looser.Snake.EnemyPlayer);
    }
  }
}
