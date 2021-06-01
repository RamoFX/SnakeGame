using System;
using System.Drawing;



namespace SnakeGame.Modules.Extensions {
  static class PointExtensions {
    // Basic
    public static Point GetModified(this Point point, Func<int, int, int> modifierX, Func<int, int, int> modifierY) {
      return new(
        modifierX(point.X, 0),
        modifierY(point.Y, 1)
      );
    }

    public static Point GetModified(this Point point, Func<int, int, int> modifier) {
      return point.GetModified(modifier, modifier);
    }



    // Scaling
    public static Point GetScaled(this Point point, int scaleFactor) {
      return point.GetModified( (n, _) => n * scaleFactor );
    }

    public static Point GetUnscaled(this Point point, int scaleFactor) {
      return point.GetModified((n, _) => n / scaleFactor);
    }



    // Other
    public static Point GetOffset(this Point point, Point offset) {
      return point.GetModified(
        (n, idx) => n + new int[2] { offset.X, offset.Y }[idx]
      );
    }

    public static int[] ToArray(this Point point) {
      return new int[2] { point.X, point.Y };
    }
  }
}
