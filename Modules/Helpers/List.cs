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
    class List {
      public static List<TItem> MoveLastToStart<TItem>(List<TItem> list) {
        if (new int[] { 2, 3 }.Contains(list.Count))
          list.Reverse();

        else if (list.Count > 1)
          list = list
            .Prepend(list[list.Count - 1])
            .Where((_, idx) => idx != list.Count)
            .ToList();

        return list;
      }

      public static TItem GetByIteratedIndex<TItem>(List<TItem> list, int iteratedIndex) {
        return list[iteratedIndex % list.Count];
      }
    }
  }
}
