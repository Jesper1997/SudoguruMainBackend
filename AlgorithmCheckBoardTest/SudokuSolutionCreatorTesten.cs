using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SudokuControlAlgorithme;
using SudokuBoard;

namespace AlgorithmCheckBoardTest
{
    public class SudokuSolutionCreatorTesten
    {
        // average sudoku
        [Fact]
        public void TestFillInBoard()
        {
            SudokuBoard.SudokuBoard board = new SudokuBoard.SudokuBoard();
            board.sudokuSquares = new List<SudokuSquare> { 
                //Start first row
                new SudokuSquare{ x = 0, y = 0, value = 1 },
                new SudokuSquare{ x = 1, y = 0, value = 0 },
                new SudokuSquare{ x = 2, y = 0, value = 7 },
                new SudokuSquare{ x = 3, y = 0, value = 0 },
                new SudokuSquare{ x = 4, y = 0, value = 0 },
                new SudokuSquare{ x = 5, y = 0, value = 0 },
                new SudokuSquare{ x = 6, y = 0, value = 9 },
                new SudokuSquare{ x = 7, y = 0, value = 8 },
                new SudokuSquare{ x = 8, y = 0, value = 5 },
                //Start Second row
                new SudokuSquare{ x = 0, y = 1, value = 0 },
                new SudokuSquare{ x = 1, y = 1, value = 0 },
                new SudokuSquare{ x = 2, y = 1, value = 0 },
                new SudokuSquare{ x = 3, y = 1, value = 6 },
                new SudokuSquare{ x = 4, y = 1, value = 5 },
                new SudokuSquare{ x = 5, y = 1, value = 0 },
                new SudokuSquare{ x = 6, y = 1, value = 0 },
                new SudokuSquare{ x = 7, y = 1, value = 0 },
                new SudokuSquare{ x = 8, y = 1, value = 3 },
                //start third row
                new SudokuSquare{ x = 0, y = 2, value = 3 },
                new SudokuSquare{ x = 1, y = 2, value = 0 },
                new SudokuSquare{ x = 2, y = 2, value = 0 },
                new SudokuSquare{ x = 3, y = 2, value = 1 },
                new SudokuSquare{ x = 4, y = 2, value = 0 },
                new SudokuSquare{ x = 5, y = 2, value = 0 },
                new SudokuSquare{ x = 6, y = 2, value = 0 },
                new SudokuSquare{ x = 7, y = 2, value = 6 },
                new SudokuSquare{ x = 8, y = 2, value = 0 },
                //Start fourth row
                new SudokuSquare{ x = 0, y = 3, value = 0 },
                new SudokuSquare{ x = 1, y = 3, value = 0 },
                new SudokuSquare{ x = 2, y = 3, value = 0 },
                new SudokuSquare{ x = 3, y = 3, value = 0 },
                new SudokuSquare{ x = 4, y = 3, value = 7 },
                new SudokuSquare{ x = 5, y = 3, value = 0 },
                new SudokuSquare{ x = 6, y = 3, value = 0 },
                new SudokuSquare{ x = 7, y = 3, value = 0 },
                new SudokuSquare{ x = 8, y = 3, value = 4 },
                //start fhith row
                new SudokuSquare{ x = 0, y = 4, value = 5 },
                new SudokuSquare{ x = 1, y = 4, value = 0 },
                new SudokuSquare{ x = 2, y = 4, value = 0 },
                new SudokuSquare{ x = 3, y = 4, value = 2 },
                new SudokuSquare{ x = 4, y = 4, value = 0 },
                new SudokuSquare{ x = 5, y = 4, value = 0 },
                new SudokuSquare{ x = 6, y = 4, value = 0 },
                new SudokuSquare{ x = 7, y = 4, value = 1 },
                new SudokuSquare{ x = 8, y = 4, value = 0 },
                //Start sixth row
                new SudokuSquare{ x = 0, y = 5, value = 2 },
                new SudokuSquare{ x = 1, y = 5, value = 0 },
                new SudokuSquare{ x = 2, y = 5, value = 0 },
                new SudokuSquare{ x = 3, y = 5, value = 0 },
                new SudokuSquare{ x = 4, y = 5, value = 4 },
                new SudokuSquare{ x = 5, y = 5, value = 0 },
                new SudokuSquare{ x = 6, y = 5, value = 5 },
                new SudokuSquare{ x = 7, y = 5, value = 0 },
                new SudokuSquare{ x = 8, y = 5, value = 0 },
                //start seventh row
                new SudokuSquare{ x = 0, y = 6, value = 0 },
                new SudokuSquare{ x = 1, y = 6, value = 5 },
                new SudokuSquare{ x = 2, y = 6, value = 0 },
                new SudokuSquare{ x = 3, y = 6, value = 4 },
                new SudokuSquare{ x = 4, y = 6, value = 0 },
                new SudokuSquare{ x = 5, y = 6, value = 0 },
                new SudokuSquare{ x = 6, y = 6, value = 8 },
                new SudokuSquare{ x = 7, y = 6, value = 0 },
                new SudokuSquare{ x = 8, y = 6, value = 0 },
                //start eigth row
                new SudokuSquare{ x = 0, y = 7, value = 8 },
                new SudokuSquare{ x = 1, y = 7, value = 0 },
                new SudokuSquare{ x = 2, y = 7, value = 0 },
                new SudokuSquare{ x = 3, y = 7, value = 7 },
                new SudokuSquare{ x = 4, y = 7, value = 0 },
                new SudokuSquare{ x = 5, y = 7, value = 5 },
                new SudokuSquare{ x = 6, y = 7, value = 0 },
                new SudokuSquare{ x = 7, y = 7, value = 0 },
                new SudokuSquare{ x = 8, y = 7, value = 6 },
                //Start last Row
                new SudokuSquare{ x = 0, y = 8, value = 0 },
                new SudokuSquare{ x = 1, y = 8, value = 0 },
                new SudokuSquare{ x = 2, y = 8, value = 6 },
                new SudokuSquare{ x = 3, y = 8, value = 9 },
                new SudokuSquare{ x = 4, y = 8, value = 0 },
                new SudokuSquare{ x = 5, y = 8, value = 8 },
                new SudokuSquare{ x = 6, y = 8, value = 3 },
                new SudokuSquare{ x = 7, y = 8, value = 5 },
                new SudokuSquare{ x = 8, y = 8, value = 7 }
            };

            SudokuSolutionCreator sudoku = new SudokuSolutionCreator();
            SudokuAlgorithm Checkforduplicates = new SudokuAlgorithm();
            board = sudoku.CreateSolution(board);
            board = Checkforduplicates.SudokuSetUpForControlle(board);
            bool noduplicates = true;
            bool NoZeros = true;
            foreach(SudokuSquare square in board.sudokuSquares)
            {
                if(!square.Correct)
                {
                    noduplicates = false;
                }
                if(square.value == 0)
                {
                    NoZeros = false;
                }
            }

            Assert.True(NoZeros);
            Assert.True(noduplicates);
            
        }

        [Fact]
        public void TestFillinBoardHardSudoku()
        {
            SudokuBoard.SudokuBoard board = new SudokuBoard.SudokuBoard();
            board.sudokuSquares = new List<SudokuSquare> { 
                //Start first row
                new SudokuSquare{ x = 0, y = 0, value = 9 },
                new SudokuSquare{ x = 1, y = 0, value = 0 },
                new SudokuSquare{ x = 2, y = 0, value = 0 },
                new SudokuSquare{ x = 3, y = 0, value = 0 },
                new SudokuSquare{ x = 4, y = 0, value = 0 },
                new SudokuSquare{ x = 5, y = 0, value = 0 },
                new SudokuSquare{ x = 6, y = 0, value = 0 },
                new SudokuSquare{ x = 7, y = 0, value = 0 },
                new SudokuSquare{ x = 8, y = 0, value = 1 },
                //Start Second row
                new SudokuSquare{ x = 0, y = 1, value = 1 },
                new SudokuSquare{ x = 1, y = 1, value = 4 },
                new SudokuSquare{ x = 2, y = 1, value = 0 },
                new SudokuSquare{ x = 3, y = 1, value = 0 },
                new SudokuSquare{ x = 4, y = 1, value = 0 },
                new SudokuSquare{ x = 5, y = 1, value = 6 },
                new SudokuSquare{ x = 6, y = 1, value = 0 },
                new SudokuSquare{ x = 7, y = 1, value = 3 },
                new SudokuSquare{ x = 8, y = 1, value = 0 },
                //start third row
                new SudokuSquare{ x = 0, y = 2, value = 0 },
                new SudokuSquare{ x = 1, y = 2, value = 0 },
                new SudokuSquare{ x = 2, y = 2, value = 5 },
                new SudokuSquare{ x = 3, y = 2, value = 0 },
                new SudokuSquare{ x = 4, y = 2, value = 0 },
                new SudokuSquare{ x = 5, y = 2, value = 7 },
                new SudokuSquare{ x = 6, y = 2, value = 8 },
                new SudokuSquare{ x = 7, y = 2, value = 0 },
                new SudokuSquare{ x = 8, y = 2, value = 0 },
                //Start fourth row
                new SudokuSquare{ x = 0, y = 3, value = 4 },
                new SudokuSquare{ x = 1, y = 3, value = 0 },
                new SudokuSquare{ x = 2, y = 3, value = 0 },
                new SudokuSquare{ x = 3, y = 3, value = 1 },
                new SudokuSquare{ x = 4, y = 3, value = 0 },
                new SudokuSquare{ x = 5, y = 3, value = 0 },
                new SudokuSquare{ x = 6, y = 3, value = 0 },
                new SudokuSquare{ x = 7, y = 3, value = 2 },
                new SudokuSquare{ x = 8, y = 3, value = 5 },
                //start fhith row
                new SudokuSquare{ x = 0, y = 4, value = 0 },
                new SudokuSquare{ x = 1, y = 4, value = 5 },
                new SudokuSquare{ x = 2, y = 4, value = 1 },
                new SudokuSquare{ x = 3, y = 4, value = 7 },
                new SudokuSquare{ x = 4, y = 4, value = 0 },
                new SudokuSquare{ x = 5, y = 4, value = 0 },
                new SudokuSquare{ x = 6, y = 4, value = 9 },
                new SudokuSquare{ x = 7, y = 4, value = 0 },
                new SudokuSquare{ x = 8, y = 4, value = 0 },
                //Start sixth row
                new SudokuSquare{ x = 0, y = 5, value = 0 },
                new SudokuSquare{ x = 1, y = 5, value = 0 },
                new SudokuSquare{ x = 2, y = 5, value = 9 },
                new SudokuSquare{ x = 3, y = 5, value = 0 },
                new SudokuSquare{ x = 4, y = 5, value = 0 },
                new SudokuSquare{ x = 5, y = 5, value = 0 },
                new SudokuSquare{ x = 6, y = 5, value = 0 },
                new SudokuSquare{ x = 7, y = 5, value = 0 },
                new SudokuSquare{ x = 8, y = 5, value = 8 },
                //start seventh row
                new SudokuSquare{ x = 0, y = 6, value = 0 },
                new SudokuSquare{ x = 1, y = 6, value = 8 },
                new SudokuSquare{ x = 2, y = 6, value = 2 },
                new SudokuSquare{ x = 3, y = 6, value = 0 },
                new SudokuSquare{ x = 4, y = 6, value = 6 },
                new SudokuSquare{ x = 5, y = 6, value = 0 },
                new SudokuSquare{ x = 6, y = 6, value = 0 },
                new SudokuSquare{ x = 7, y = 6, value = 7 },
                new SudokuSquare{ x = 8, y = 6, value = 0 },
                //start eigth row
                new SudokuSquare{ x = 0, y = 7, value = 0 },
                new SudokuSquare{ x = 1, y = 7, value = 0 },
                new SudokuSquare{ x = 2, y = 7, value = 4 },
                new SudokuSquare{ x = 3, y = 7, value = 3 },
                new SudokuSquare{ x = 4, y = 7, value = 9 },
                new SudokuSquare{ x = 5, y = 7, value = 0 },
                new SudokuSquare{ x = 6, y = 7, value = 0 },
                new SudokuSquare{ x = 7, y = 7, value = 5 },
                new SudokuSquare{ x = 8, y = 7, value = 0 },
                //Start last Row
                new SudokuSquare{ x = 0, y = 8, value = 0 },
                new SudokuSquare{ x = 1, y = 8, value = 0 },
                new SudokuSquare{ x = 2, y = 8, value = 0 },
                new SudokuSquare{ x = 3, y = 8, value = 4 },
                new SudokuSquare{ x = 4, y = 8, value = 7 },
                new SudokuSquare{ x = 5, y = 8, value = 2 },
                new SudokuSquare{ x = 6, y = 8, value = 0 },
                new SudokuSquare{ x = 7, y = 8, value = 8 },
                new SudokuSquare{ x = 8, y = 8, value = 0 }
            };

            SudokuSolutionCreator sudoku = new SudokuSolutionCreator();
            SudokuAlgorithm Checkforduplicates = new SudokuAlgorithm();
            board = sudoku.CreateSolution(board);
            board = Checkforduplicates.SudokuSetUpForControlle(board);
            bool noduplicates = true;
            bool NoZeros = true;
            foreach (SudokuSquare square in board.sudokuSquares)
            {
                if (!square.Correct)
                {
                    noduplicates = false;
                }
                if (square.value == 0)
                {
                    NoZeros = false;
                }
            }

            Assert.True(NoZeros);
            Assert.True(noduplicates);
        }

        [Fact]
        public void TestFillinBoardSecondHardSudoku()
        {
            SudokuBoard.SudokuBoard board = new SudokuBoard.SudokuBoard();
            board.sudokuSquares = new List<SudokuSquare> { 
                //Start first row
                new SudokuSquare{ x = 0, y = 0, value = 0 },
                new SudokuSquare{ x = 1, y = 0, value = 2 },
                new SudokuSquare{ x = 2, y = 0, value = 0 },
                new SudokuSquare{ x = 3, y = 0, value = 9 },
                new SudokuSquare{ x = 4, y = 0, value = 0 },
                new SudokuSquare{ x = 5, y = 0, value = 0 },
                new SudokuSquare{ x = 6, y = 0, value = 0 },
                new SudokuSquare{ x = 7, y = 0, value = 6 },
                new SudokuSquare{ x = 8, y = 0, value = 0 },
                //Start Second row
                new SudokuSquare{ x = 0, y = 1, value = 0 },
                new SudokuSquare{ x = 1, y = 1, value = 3 },
                new SudokuSquare{ x = 2, y = 1, value = 0 },
                new SudokuSquare{ x = 3, y = 1, value = 0 },
                new SudokuSquare{ x = 4, y = 1, value = 2 },
                new SudokuSquare{ x = 5, y = 1, value = 7 },
                new SudokuSquare{ x = 6, y = 1, value = 8 },
                new SudokuSquare{ x = 7, y = 1, value = 0 },
                new SudokuSquare{ x = 8, y = 1, value = 0 },
                //start third row
                new SudokuSquare{ x = 0, y = 2, value = 0 },
                new SudokuSquare{ x = 1, y = 2, value = 9 },
                new SudokuSquare{ x = 2, y = 2, value = 0 },
                new SudokuSquare{ x = 3, y = 2, value = 0 },
                new SudokuSquare{ x = 4, y = 2, value = 4 },
                new SudokuSquare{ x = 5, y = 2, value = 0 },
                new SudokuSquare{ x = 6, y = 2, value = 2 },
                new SudokuSquare{ x = 7, y = 2, value = 1 },
                new SudokuSquare{ x = 8, y = 2, value = 0 },
                //Start fourth row
                new SudokuSquare{ x = 0, y = 3, value = 0 },
                new SudokuSquare{ x = 1, y = 3, value = 0 },
                new SudokuSquare{ x = 2, y = 3, value = 9 },
                new SudokuSquare{ x = 3, y = 3, value = 0 },
                new SudokuSquare{ x = 4, y = 3, value = 7 },
                new SudokuSquare{ x = 5, y = 3, value = 0 },
                new SudokuSquare{ x = 6, y = 3, value = 0 },
                new SudokuSquare{ x = 7, y = 3, value = 0 },
                new SudokuSquare{ x = 8, y = 3, value = 0 },
                //start fhith row
                new SudokuSquare{ x = 0, y = 4, value = 1 },
                new SudokuSquare{ x = 1, y = 4, value = 6 },
                new SudokuSquare{ x = 2, y = 4, value = 0 },
                new SudokuSquare{ x = 3, y = 4, value = 0 },
                new SudokuSquare{ x = 4, y = 4, value = 0 },
                new SudokuSquare{ x = 5, y = 4, value = 5 },
                new SudokuSquare{ x = 6, y = 4, value = 0 },
                new SudokuSquare{ x = 7, y = 4, value = 9 },
                new SudokuSquare{ x = 8, y = 4, value = 7 },
                //Start sixth row
                new SudokuSquare{ x = 0, y = 5, value = 3 },
                new SudokuSquare{ x = 1, y = 5, value = 4 },
                new SudokuSquare{ x = 2, y = 5, value = 0 },
                new SudokuSquare{ x = 3, y = 5, value = 2 },
                new SudokuSquare{ x = 4, y = 5, value = 0 },
                new SudokuSquare{ x = 5, y = 5, value = 6 },
                new SudokuSquare{ x = 6, y = 5, value = 0 },
                new SudokuSquare{ x = 7, y = 5, value = 0 },
                new SudokuSquare{ x = 8, y = 5, value = 0 },
                //start seventh row
                new SudokuSquare{ x = 0, y = 6, value = 0 },
                new SudokuSquare{ x = 1, y = 6, value = 0 },
                new SudokuSquare{ x = 2, y = 6, value = 0 },
                new SudokuSquare{ x = 3, y = 6, value = 0 },
                new SudokuSquare{ x = 4, y = 6, value = 0 },
                new SudokuSquare{ x = 5, y = 6, value = 4 },
                new SudokuSquare{ x = 6, y = 6, value = 0 },
                new SudokuSquare{ x = 7, y = 6, value = 0 },
                new SudokuSquare{ x = 8, y = 6, value = 8 },
                //start eigth row
                new SudokuSquare{ x = 0, y = 7, value = 2 },
                new SudokuSquare{ x = 1, y = 7, value = 1 },
                new SudokuSquare{ x = 2, y = 7, value = 4 },
                new SudokuSquare{ x = 3, y = 7, value = 0 },
                new SudokuSquare{ x = 4, y = 7, value = 0 },
                new SudokuSquare{ x = 5, y = 7, value = 0 },
                new SudokuSquare{ x = 6, y = 7, value = 0 },
                new SudokuSquare{ x = 7, y = 7, value = 0 },
                new SudokuSquare{ x = 8, y = 7, value = 0 },
                //Start last Row
                new SudokuSquare{ x = 0, y = 8, value = 9 },
                new SudokuSquare{ x = 1, y = 8, value = 7 },
                new SudokuSquare{ x = 2, y = 8, value = 0 },
                new SudokuSquare{ x = 3, y = 8, value = 3 },
                new SudokuSquare{ x = 4, y = 8, value = 0 },
                new SudokuSquare{ x = 5, y = 8, value = 0 },
                new SudokuSquare{ x = 6, y = 8, value = 1 },
                new SudokuSquare{ x = 7, y = 8, value = 0 },
                new SudokuSquare{ x = 8, y = 8, value = 0 }
            };

            SudokuSolutionCreator sudoku = new SudokuSolutionCreator();
            SudokuAlgorithm Checkforduplicates = new SudokuAlgorithm();
            board = sudoku.CreateSolution(board);
            board = Checkforduplicates.SudokuSetUpForControlle(board);
            bool noduplicates = true;
            bool NoZeros = true;
            foreach (SudokuSquare square in board.sudokuSquares)
            {
                if (!square.Correct)
                {
                    noduplicates = false;
                }
                if (square.value == 0)
                {
                    NoZeros = false;
                }
            }

            Assert.True(NoZeros);
            Assert.True(noduplicates);
        }
    }
}
