using System.Drawing;



namespace SnakeGame.Modules.Core {
  class Preferences {
    public readonly int ScaleFactor;
    public readonly Size ArenaSize;
    public readonly (int, int) GrowPerFood;
    public readonly int FramesPerSecond;

    public Preferences(
      int? scaleFactor = null,
      Size? arenaSize = null,
      (int, int)? growPerFood = null,
      int? framesPerSecond = null
    ) {
      this.ScaleFactor = scaleFactor ?? 32;
      this.ArenaSize = arenaSize ?? new(16, 16);
      this.GrowPerFood = growPerFood ?? (1, 5);
      this.FramesPerSecond = framesPerSecond ?? 30;
    }
  }
}
