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
    private void Window_Tick_Started() {
      // update direction
      snake.CurrentDirection = snake.NextDirection;

      // move snake
      snake.Move();

      // snake death
      if (snake.Parts.Where(part => part.Location == snake.Parts.ElementAt(0).Location).Count() > 1) {
        GameState = GameStates.Ended;
      }

      // food eaten check
      if (snake.Parts[0].Location == food.Location) {
        food = new Food(Positioning.Random(snake.Parts));
        FoodEatenCount++;
      } else {
        snake.Parts.RemoveAt(snake.Parts.Count - 1);
      }
    }
  }
}
