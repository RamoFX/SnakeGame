using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;

namespace Snake {
  public partial class Window : Form {
    class Drawing {
      public static void Draw(Graphics graphics, Element element) {
        graphics.FillRectangle(element.Brush, Scaling.Scale(element.Rectangle));
      }

      public static void DrawText(Graphics graphics, Element element, string text, Brush brush) {
        graphics.DrawString(text, DefaultFont, brush, Scaling.Scale(element.Location));
      }

      public static void DrawCoordinates(Graphics graphics, Element element, Brush brush) {
        DrawText(graphics, element, $"{ element.Location.X }, { element.Location.Y }", brush);
      }

      public static void Draw(Graphics graphics, IEnumerable<Element> elements) {
        for (int i = 0; i < elements.Count(); i++) {
          Element element = elements.ElementAt(i);
          Draw(graphics, element);
          //DrawCoordinates(graphics, element, Brushes.Red);
        }
      }
    }
  }
}
