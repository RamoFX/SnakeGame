using System;
using System.Drawing;



namespace SnakeGame.Modules.Extensions {
  static class ScaleExtensions {
    // Basic
    public static Size GetModified(this Size size, Func<int, int, int> modifierWidth, Func<int, int, int> modifierHeight) {
      return new(
        modifierWidth(size.Width, 0),
        modifierHeight(size.Height, 1)
      );
    }

    public static Size GetModified(this Size size, Func<int, int, int> modifier) {
      return size.GetModified(modifier, modifier);
    }



    // Scaling
    public static Size GetScaled(this Size size, int scaleFactor) {
      return size.GetModified( (n, _) => n * scaleFactor );
    }

    public static Size GetUnscaled(this Size size, int scaleFactor) {
      return size.GetModified((n, _) => n / scaleFactor);
    }



    // Other
    public static Point GetCenter(this Size size) {
      return new Point(
        size.GetModified( (_, idx) => new int[2] { size.Width, size.Height }[idx] / 2 )
      );
    }

    public static int[] ToArray(this Size size) {
      return new int[2] { size.Width, size.Height };
    }
  }
}
