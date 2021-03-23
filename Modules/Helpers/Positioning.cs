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
    class Positioning {
      private static Size GetUnscaledGameFieldSize() {
        return Scaling.Unscale(GameField.Size);
      } 

      // Center
      public static Point Center() {
        return new Point(
          Scaling.Divide(GetUnscaledGameFieldSize(), 2)
        );
      }

      public static Point Center(int offset_x, int offset_y) {
        Size DividedUnscaledGameFieldSize = Scaling.Divide(GetUnscaledGameFieldSize(), 2);

        return new Point(
          DividedUnscaledGameFieldSize.Width + offset_x,
          DividedUnscaledGameFieldSize.Height + offset_y
        );
      }

      // Random
      public static Point Random() {
        return new Point(
          Window.Random.Next(GetUnscaledGameFieldSize().Width),
          Window.Random.Next(GetUnscaledGameFieldSize().Height)
        );
      }

      public static Point Random(Point excludePoint) {
        Point randomPoint = Random();

        while (randomPoint == excludePoint) {
          randomPoint = Random();
        }

        return randomPoint;
      }

      public static Point Random(IEnumerable<Point> excludePoints) {
        Point randomPoint = Random();

        while (excludePoints.Contains(randomPoint)) {
          randomPoint = Random();
        }

        return randomPoint;
      }

      public static Point Random(IEnumerable<Element> excludeElements) {
        List<Point> excludePoints = excludeElements
                                      .Select((Element element) => element.Location)
                                      .ToList();

        Point randomPoint = Random(excludePoints);

        return randomPoint;
      }

      // Direction
      public enum Direction { Up, Down, Left, Right }

      public static Direction OppositeDirection(Direction direction) {
        return (Direction) (int) direction + ( (int) direction % 2 == 0 ? 1 : -1 );
      }

      public static Direction RandomDirection() {
        return (Direction) Window.Random.Next(Enum.GetValues(typeof(Direction)).Length);
      }
    }
  }
}
