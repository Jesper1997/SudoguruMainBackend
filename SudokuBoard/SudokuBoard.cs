using System;
using System.ComponentModel.DataAnnotations;

namespace SudokuBoard
{
    public class SudokuBoard
    {
        [Key]
        public int Id { get; set; }
        public SudokuSquare[] sudokuSquares { get; set; }
    }
}
