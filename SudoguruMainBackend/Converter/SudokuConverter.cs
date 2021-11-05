using SudoguruMainBackend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SudoguruMainBackend.Converter
{
    public class SudokuConverter : ISudokuConverter
    {
        public SudokuBoard.SudokuBoard BoardConverter(BoardViewModel receivedboard)
        {
            List<SudokuBoard.SudokuSquare> squares = new List<SudokuBoard.SudokuSquare>();
            SudokuBoard.SudokuBoard board = new SudokuBoard.SudokuBoard();
            for (int x = 0; x < receivedboard.squares.Length; x++)
            {
                SudokuBoard.SudokuSquare sudokuSquare = new SudokuBoard.SudokuSquare
                {
                    x = receivedboard.squares[x].x,
                    y = receivedboard.squares[x].y,
                    SquareId = receivedboard.squares[x].id,
                    value = receivedboard.squares[x].value
                };
                squares.Add(sudokuSquare);
            }
            board.sudokuSquares = squares;
            return board;
        }
    }
}
