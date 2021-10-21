using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuBoard
{
    public class SudokuSquare : ICloneable
    {
        public int id { get; set; }
        public int BoardId { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int value { get; set; }
        public bool Correct { get; set; } = true;
        public List<int> PossibleNumbers { get; set; } = new List<int>();

        public object Clone()
        {
            SudokuSquare square = new SudokuSquare
            {
                id = this.id,
                x = this.x,
                y = this.y,
                value = this.value,
                Correct = this.Correct,
                PossibleNumbers = new List<int>(this.PossibleNumbers)
            };
            return square;
        }
    }
}
