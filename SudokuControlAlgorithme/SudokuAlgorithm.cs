using System;
using System.Collections.Generic;
using System.Linq;
using SudokuBoard;

namespace SudokuControlAlgorithme
{
    public class SudokuAlgorithm : ISudokuCheckAlgoritme.ISudokuCheckAlgorithme
    {
        public int size;

        public SudokuBoard.SudokuBoard SudokuSetUpForControlle(SudokuBoard.SudokuBoard board)
        {
            int centerPointX = 1;
            int centerPointY = 1;
            foreach (SudokuSquare square in board.sudokuSquares)
            {
                if(square.x == 0)
                {
                    CheckRowForDuplicateds(board, square.y);
                }
                if(square.y == 0)
                {
                    CheckColumnForDuplicates(board, square.x);
                }
                if(square.x == centerPointX && square.y == centerPointY )
                {
                    CheckSquareForDuplicates(board,centerPointX, centerPointY);
                    centerPointX = centerPointX + 3;
                    if (centerPointX < 8)
                    {
                        centerPointX = 1;
                        centerPointY = centerPointY + 3;
                    }

                }
            }
            return board;
        }

        private void CheckRowForDuplicateds(SudokuBoard.SudokuBoard board, int y)
        {
            var row = board.sudokuSquares.Where(square => square.y == y).ToArray();
            List<int> rowNumbers = ExtractNumbers(row);
            CheckForDuplicates(row, rowNumbers);
        }

        private void CheckColumnForDuplicates(SudokuBoard.SudokuBoard board, int x)
        {
            var column = board.sudokuSquares.Where(square => square.x == x).ToArray();
            List<int> ColumnNumbers = ExtractNumbers(column);
            CheckForDuplicates(column, ColumnNumbers);
        }

        private void CheckSquareForDuplicates(SudokuBoard.SudokuBoard board, int x , int y)
        {
            var square = board.sudokuSquares.Where(square => square.x == x - 1 || square.x == x|| square.x == x+1).ToArray();
            square = square.Where(square => square.y == y - 1 || square.y == y || square.y == y + 1).ToArray();
            List<int> squareNumbers = ExtractNumbers(square);
            CheckForDuplicates(square, squareNumbers);

        }

        private static List<int> ExtractNumbers(SudokuSquare[] row)
        {
            List<int> rowNumbers = new List<int>();
            for (int x = 0; x < row.Length; x++)
            {
                if (row[x].value != 0)
                {
                    rowNumbers.Add(row[x].value);
                }
            }

            return rowNumbers;
        }

        private void CheckForDuplicates(SudokuSquare[] row, List<int> rowNumbers)
        {
            if (rowNumbers.GroupBy(X => X).Any(g => g.Count() > 1))
            {
                WhereIsTheDuplicate(row);
            }
        }

        private void WhereIsTheDuplicate(SudokuSquare[] Squares)
        {
            for (int i = 0; i < Squares.Length; i++)
            {
                for (int j = 0; j < Squares.Length; j++)
                {
                    if (i != j)
                    {
                        if (Squares[i].value == Squares[j].value)
                        {
                            Squares[i].Correct = false;
                            Squares[j].Correct = false;

                        }
                    }
                }
            }
        }
    }
}
