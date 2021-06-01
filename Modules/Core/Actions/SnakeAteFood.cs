using System.Text;

using SnakeGame.Modules.Elements.Complex;
using SnakeGame.Modules.Extensions;



namespace SnakeGame.Modules.Core.Actions {
  class SnakeAteFood {
    public static void Fire(Player eater) {
      StringBuilder labelText = new($"{ eater.Name.Capitalize() }: { ( eater.Snake.FoodEatenCount * 10 ).ToString().PadLeft(5, '0') }");
      Storage.Controls.Find($"Label_Score_{ eater.Id.Capitalize() }", true)[0].Text = labelText.ToString();
    }
  }
}
