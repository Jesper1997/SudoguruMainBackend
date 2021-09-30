using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuBoard
{
    public class SudokuSquare
    {
        public int id { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int value { get; set; }
        public bool Correct { get; set; } = true;
        public List<int> PossibleNumbers { get; set; } = new List<int>();
    }
}
