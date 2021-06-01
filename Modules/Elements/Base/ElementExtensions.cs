using System;

using SnakeGame.Modules.Extensions;



namespace SnakeGame.Modules.Elements.Base {
  static class ElementExtensions {
    // Basic
    public static Element GetModified(
      this Element element,
      Func<int, int, int> modifierX,
      Func<int, int, int> modifierY,
      Func<int, int, int> modifierWidth,
      Func<int, int, int> modifierHeight
    ) {
      return new(
        element.Rectangle.Location.GetModified(modifierX, modifierY),
        element.Rectangle.Size.GetModified(modifierWidth, modifierHeight),
        element.IsEllipse,
        element.Brush
      );
    }

    public static Element GetModified(
      this Element element,
      Func<int, int, int> modifierLocation,
      Func<int, int, int> modifierSize
    ) {
      return element.GetModified(modifierLocation, modifierLocation, modifierSize, modifierSize);
    }

    public static Element GetModified(
      this Element element,
      Func<int, int, int> modifier
    ) {
      return element.GetModified(modifier, modifier);
    }



    // Scaling
    public static Element GetScaled(this Element element, int scaleFactor) {
      return element.GetModified((n, _) => n * scaleFactor);
    }

    public static Element GetUnscaled(this Element element, int scaleFactor) {
      return element.GetModified((n, _) => n / scaleFactor);
    }
  }
}
