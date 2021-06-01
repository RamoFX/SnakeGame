using System;
using System.Drawing;



namespace SnakeGame.Modules.Extensions {
  static class RectangleExtensions {
    // Basic
    public static Rectangle GetModified(
      this Rectangle rectangle,
      Func<int, int, int> modifierX,
      Func<int, int, int> modifierY,
      Func<int, int, int> modifierWidth,
      Func<int, int, int> modifierHeight
    ) {
      return new(
        rectangle.Location.GetModified(modifierX, modifierY),
        rectangle.Size.GetModified(modifierWidth, modifierHeight)
      );
    }

    public static Rectangle GetModified(
      this Rectangle rectangle,
      Func<int, int, int> modifierLocation,
      Func<int, int, int> modifierSize
    ) {
      return rectangle.GetModified(modifierLocation, modifierLocation, modifierSize, modifierSize);
    }

    public static Rectangle GetModified(
      this Rectangle rectangle,
      Func<int, int, int> modifier
    ) {
      return rectangle.GetModified(modifier, modifier);
    }



    // Scaling
    public static Rectangle GetScaled(this Rectangle rectangle, int scaleFactor) {
      return rectangle.GetModified( (n, _) => n * scaleFactor );
    }

    public static Rectangle GetUnscaled(this Rectangle rectangle, int scaleFactor) {
      return rectangle.GetModified((n, _) => n / scaleFactor);
    }
  }
}
