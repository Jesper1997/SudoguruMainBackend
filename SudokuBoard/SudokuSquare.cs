using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace SudokuBoard
{
    public class SudokuSquare : ICloneable
    {
        [JsonIgnore]
        [Key]
        public int id { get; set; }
        [Required]
        public int SquareId{ get; set; }
        [JsonIgnore]
        [Required]
        public int SudokuBoardId { get; set; }
        [JsonIgnore]
        [Required]
        public SudokuBoard SudokuBoard { get; set; }
        [Required]
        public int x { get; set; }
        [Required]
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
                SquareId = this.SquareId,
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
