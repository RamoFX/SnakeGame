using System.Windows.Forms;

using SnakeGame.Modules.Core.Actions;
using SnakeGame.Modules.Elements.Complex;
using SnakeGame.Modules.Helpers;



namespace SnakeGame.Modules.Core {
  class Keyboard {
    public static void KeyDown(KeyEventArgs e) {
      Keys pressedKey = e.KeyCode;

      // Check game state -> Check key -> Do something
      switch (Storage.Runtime.GameState) {
        case GameStates.Awaiting:
          GameStart.Fire();
          break;

        case GameStates.Playing:
          Keys[][] playersMoveKeys = new Keys[2][] {
            new Keys[4] { Keys.W,  Keys.S,    Keys.A,    Keys.D },
            new Keys[4] { Keys.Up, Keys.Down, Keys.Left, Keys.Right }
          };

          for (int playerKeysIdx = 0; playerKeysIdx < playersMoveKeys.Length; playerKeysIdx++) {
            Keys[] currentPlayerKeys = playersMoveKeys[playerKeysIdx];
            Snake currentSnake = Storage.Runtime.Players[playerKeysIdx].Snake;

            for (int keyIdx = 0; keyIdx < currentPlayerKeys.Length; keyIdx++) {
              Keys currentKey = currentPlayerKeys[keyIdx];

              if (currentKey == pressedKey) {
                bool oneSegmentOnly = currentSnake.Segments.Count == 1;
                bool notOpposite = (Positioning.Direction) keyIdx != Positioning.OppositeDirection(currentSnake.CurrentDirection);

                if (oneSegmentOnly || notOpposite) {
                  currentSnake.NextDirection = (Positioning.Direction) keyIdx;
                }
              }
            }
          }
          break;

        case GameStates.Ended:
          break;
      }
    }
  }
}
