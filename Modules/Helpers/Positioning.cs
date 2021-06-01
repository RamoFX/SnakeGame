using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using SnakeGame.Modules.Core;
using SnakeGame.Modules.Elements.Base;



namespace SnakeGame.Modules.Helpers {
  static class Positioning {
    // Random
    public static Point Random() {
      return new Point(
        Storage.Random.Next(Storage.Preferences.ArenaSize.Width),
        Storage.Random.Next(Storage.Preferences.ArenaSize.Height)
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
        .Select( (Element element) => element.Location )
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
      return (Direction) Storage.Random.Next(Enum.GetValues(typeof(Direction)).Length);
    }

    public static Direction RandomDirection(Direction excludeDirection) {
      Direction result = RandomDirection();

      while (result == excludeDirection) {
        result = RandomDirection();
      }

      return result;
    }
  }
}
