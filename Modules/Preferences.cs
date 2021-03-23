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
  partial class Window : Form {
    private static Panel GameField;
    private static Label Score;
    private static Label PressToStart;

    private static readonly Random Random = new Random();
    private static readonly Timer Timer = new Timer();

    private const int CellSize = 32;

    private static int Speed = 3;
    private static readonly Tuple<int, int> Add_a_SpeedPer_b_Food = new Tuple<int, int>(1, 5);

    private static int _FoodEatenCount = 0;
    private static int FoodEatenCount {
      get {
        return _FoodEatenCount;
      }
      set {
        Speed = 3 + ( value - value % Add_a_SpeedPer_b_Food.Item2 ) / Add_a_SpeedPer_b_Food.Item2 * Add_a_SpeedPer_b_Food.Item1;
        _FoodEatenCount = value;
        UpdateTimerInterval();
      }
    }

    private static Snake snake;
    private static Food food;

    private enum GameStates { ToBeStarted, Started, Ended }
    private GameStates GameState = GameStates.ToBeStarted;
  }
}
