using System.Text;



namespace SnakeGame.Modules.Extensions {
  static class StringExtensions {
    public static string Capitalize(this string text) {
      StringBuilder capitalized = new("");

      if (text.Length > 0)
        capitalized.Append($"{ char.ToUpper(text[0]) }{ text[1..] }");

      return capitalized.ToString();
    }
  }
}
