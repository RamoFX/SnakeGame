using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using SnakeGame.Modules.Core;
using SnakeGame.Modules.Elements.Base;
using SnakeGame.Modules.Extensions;



namespace SnakeGame.Modules.Helpers {
  static class Drawer {
    public static bool ShouldDrawCoordinates = false;

    public static void Draw(Graphics graphics, Element element) {
      if (element.IsEllipse) {
        graphics.FillEllipse(
          element.Brush,
          element.GetScaled(Storage.Preferences.ScaleFactor).Rectangle
        );
      } else {
        graphics.FillRectangle(
          element.Brush,
          element.GetScaled(Storage.Preferences.ScaleFactor).Rectangle
        );
      }

      if (ShouldDrawCoordinates)
        DrawCoordinates(graphics, element, Brushes.White);
    }

    public static void Draw(Graphics graphics, IEnumerable<Element> elements) {
      foreach (Element element in elements) {
        Draw(graphics, element);
      }
    }

    public static void DrawText(Graphics graphics, Element element, string text, Brush textBrush) {
      graphics.DrawString(
        text,
        Control.DefaultFont,
        textBrush,
        element.GetScaled(Storage.Preferences.ScaleFactor).Location
      );
    }

    public static void DrawCoordinates(Graphics graphics, Element element, Brush brush) {
      DrawText(graphics, element, $"{ element.Location.X }, { element.Location.Y }", brush);
    }
  }
}
