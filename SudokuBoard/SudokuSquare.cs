using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace SudokuBoard
{
    public class SudokuSquare : ICloneable
    {

        public int id { get; set; }
        [JsonIgnore]
        public int SudokuBoardId { get; set; }
        [JsonIgnore]
        public SudokuBoard SudokuBoard { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int value { get; set; }
        [NotMapped]
        public bool Correct { get; set; } = true;
        [NotMapped]
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
