using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SudokuBoard
{
    public class SudokuBoard
    {
        [Key]
        public int Id { get; set; }
        public List<SudokuSquare> sudokuSquares { get; set; }
    }
}
