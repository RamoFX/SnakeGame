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
    class Snake {
      public List<SnakePart> Parts;

      public Positioning.Direction CurrentDirection;
      public Positioning.Direction NextDirection;

      public Snake(Point startingPoint) {
        this.CurrentDirection = Positioning.RandomDirection();
        this.Parts = new List<SnakePart>();
        AddPart(startingPoint);
      }

      public void AddPart(Point point) {
        this.Parts.Add(new SnakePart(point));
      }

      public void AddPart(SnakePart snakePart) {
        this.Parts.Add(snakePart);
      }

      private SnakePart UpdatePartLocation(SnakePart snakePart) {
        int[] directionMatrix = new int[2] { 0, 0 };

        for (int i = 0; i < Enum.GetValues(typeof(Positioning.Direction)).Length; i++) {
          if ((int) this.CurrentDirection == i)
            directionMatrix[i / 2] = 1 * ( i % 2 == 1 ? 1 : -1 );
        }

        return new SnakePart(
          new Point(
            snakePart.Location.X + 1 * directionMatrix[1],
            snakePart.Location.Y + 1 * directionMatrix[0]
          )
        );
      }

      public void Move() {
        this.Parts = this.Parts.Prepend(this.Parts[0]).ToList();
        //this.Parts[0] = UpdatePartLocation(this.Parts[0]);

        switch (this.CurrentDirection) {
          case Positioning.Direction.Up:
            this.Parts[0] = new SnakePart(
              new Point(
                this.Parts[0].Location.X,
                this.Parts[0].Location.Y == 0 ? 16 : this.Parts[0].Location.Y - 1
              )
            );
            break;

          case Positioning.Direction.Down:
            this.Parts[0] = new SnakePart(
              new Point(
                this.Parts[0].Location.X,
                this.Parts[0].Location.Y == 16 ? 0 : this.Parts[0].Location.Y + 1
              )
            );
            break;

          case Positioning.Direction.Left:
            this.Parts[0] = new SnakePart(
              new Point(
                this.Parts[0].Location.X == 0 ? 16 : this.Parts[0].Location.X - 1,
                this.Parts[0].Location.Y
              )
            );
            break;

          case Positioning.Direction.Right:
            this.Parts[0] = new SnakePart(
              new Point(
                this.Parts[0].Location.X == 16 ? 0 : this.Parts[0].Location.X + 1,
                this.Parts[0].Location.Y
              )
            );
            break;
        }
      }
    }
  }
}
