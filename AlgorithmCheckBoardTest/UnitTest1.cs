using System;
using Xunit;
using SudokuBoard;
using SudokuControlAlgorithme;
using System.Collections.Generic;

namespace AlgorithmCheckBoardTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            bool checksameYvalue = true;
            SudokuAlgorithm sudoku = new SudokuAlgorithm();
            SudokuBoard.SudokuBoard board = new SudokuBoard.SudokuBoard
            {
                sudokuSquares = new List<SudokuSquare>
                {
                    new SudokuSquare { x = 0, y = 5, value = 1 },
                    new SudokuSquare { x = 1, y = 5, value = 3 },
                    new SudokuSquare { x = 4, y = 5, value = 5 },
                    new SudokuSquare { x = 3, y = 2, value = 1 },
                    new SudokuSquare { x = 9, y = 5, value = 9 },
                    new SudokuSquare { x = 5, y = 9, value = 9 },
                    new SudokuSquare { x = 6, y = 5, value = 9 }
                }
            };


            Assert.True(checksameYvalue);
        }

        [Fact]
        public void TestTheSquareChecker()
        {
            bool checksamevalue = false;
            SudokuAlgorithm sudoku = new SudokuAlgorithm();
            SudokuBoard.SudokuBoard board = new SudokuBoard.SudokuBoard
            {
                sudokuSquares = new List<SudokuSquare>
                {
                    new SudokuSquare { x = 0, y = 0, value = 1 },
                    new SudokuSquare { x = 1, y = 0, value = 3 },
                    new SudokuSquare { x = 2, y = 0, value = 5 },
                    new SudokuSquare { x = 0, y = 1, value = 8 },
                    new SudokuSquare { x = 1, y = 1, value = 2 },
                    new SudokuSquare { x = 2, y = 1, value = 4 },
                    new SudokuSquare { x = 0, y = 2, value = 6 },
                    new SudokuSquare { x = 1, y = 2, value = 7 },
                    new SudokuSquare { x = 2, y = 2, value = 9}
                }
            };
            sudoku.SudokuSetUpForControlle(board);
            foreach(SudokuSquare square in board.sudokuSquares)
            {
                if(!square.Correct)
                {
                    checksamevalue = true;
                }
            }

            Assert.False(checksamevalue);
        }

        [Fact]
        public void TestTheSquareCheckerWithDuplicateNumbers()
        {
            bool checksamevalue = false;
            SudokuAlgorithm sudoku = new SudokuAlgorithm();
            SudokuBoard.SudokuBoard board = new SudokuBoard.SudokuBoard
            {
                sudokuSquares = new List<SudokuSquare>
                {
                    new SudokuSquare { x = 0, y = 0, value = 1 },
                    new SudokuSquare { x = 1, y = 0, value = 3 },
                    new SudokuSquare { x = 2, y = 0, value = 5 },
                    new SudokuSquare { x = 0, y = 1, value = 8 },
                    new SudokuSquare { x = 1, y = 1, value = 2 },
                    new SudokuSquare { x = 2, y = 1, value = 6 },
                    new SudokuSquare { x = 0, y = 2, value = 6 },
                    new SudokuSquare { x = 1, y = 2, value = 7 },
                    new SudokuSquare { x = 2, y = 2, value = 9}
                }
            };
            sudoku.SudokuSetUpForControlle(board);
            foreach (SudokuSquare square in board.sudokuSquares)
            {
                if (!square.Correct)
                {
                    checksamevalue = true;
                }
            }

            Assert.True(checksamevalue);
        }

    }
}
