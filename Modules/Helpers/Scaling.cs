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
    class Scaling {
      // Point
      public static Point Multiply(Point point, int by) {
        return new Point(
          point.X * by,
          point.Y * by
        );
      }

      public static Point Divide(Point point, int by) {
        return new Point(
          point.X / by, 
          point.Y / by
        );
      }

      public static Point Scale(Point point) {
        return Multiply(point, CellSize);
      }

      public static Point Unscale(Point point) {
        return Divide(point, CellSize);
      }

      // Size
      public static Size Multiply(Size size, int by) {
        return new Size(
          size.Width * by,
          size.Height * by
        );
      }

      public static Size Divide(Size size, int by) {
        return new Size(
          size.Width / by,
          size.Height / by
        );
      }

      public static Size Scale(Size size) {
        return Multiply(size, CellSize);
      }

      public static Size Unscale(Size size) {
        return Divide(size, CellSize);
      }

      // Rectangle
      public static Rectangle Multiply(Rectangle rectangle, int by) {
        return new Rectangle(
          Multiply(rectangle.Location, by),
          Multiply(rectangle.Size, by)
        );
      }

      public static Rectangle Divide(Rectangle rectangle, int by) {
        return new Rectangle(
          Divide(rectangle.Location, by),
          Divide(rectangle.Size, by)
        );
      }

      public static Rectangle Scale(Rectangle rectangle) {
        return Multiply(rectangle, CellSize);
      }

      public static Rectangle Unscale(Rectangle rectangle) {
        return Divide(rectangle, CellSize);
      }
    }
  }
}
