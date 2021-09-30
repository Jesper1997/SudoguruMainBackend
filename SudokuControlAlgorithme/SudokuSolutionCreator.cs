using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SudokuBoard;

namespace SudokuControlAlgorithme
{
    public class SudokuSolutionCreator
    {

        List<int> NeededNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public SudokuBoard.SudokuBoard CreateSolution(SudokuBoard.SudokuBoard board)
        {
            int centerPointX = 1;
            int centerPointY = 1;
            foreach (SudokuSquare square in board.sudokuSquares)
            {
                //Get All impossiblePossible Numbers
                var NotPossibleNumbers = GetAllRowvalues(board, square);
                NotPossibleNumbers.AddRange(GetAllColumnValues(board, square));
                if (square.x == centerPointX && square.y == centerPointY)
                {
                    NotPossibleNumbers = GetAllSquareValues(board, square);
                    centerPointX = centerPointX + 3;
                    if(centerPointX > 8)
                    {
                        centerPointY = centerPointY + 3;
                        centerPointX = 1;
                    }
                }
                //Generate All possible values for that square
                generatepossibleValue(NotPossibleNumbers, square);
            }
            // start inserting values into the square until they are all filled in
            InsertValue(board);
            return board;
        }

        //Creates a row and extracts all value from that row as those numbers are impossible for that square
        private List<int> GetAllRowvalues(SudokuBoard.SudokuBoard board, SudokuSquare baseSquare)
        {
            var row = board.sudokuSquares.Where(square => square.x == baseSquare.x).ToArray();
            return ExtractNumnbersFromArray(row);
        }

        //Creates a column and extract all values from that column because those number are impossible for that square 
        private List<int> GetAllColumnValues(SudokuBoard.SudokuBoard board, SudokuSquare baseSquare)
        {
            var Column = board.sudokuSquares.Where(square => square.y == baseSquare.y).ToArray();
            return ExtractNumnbersFromArray(Column);
        }

        // create a big square(3X3) and extract all impossible numbers from that big square
        private List<int> GetAllSquareValues (SudokuBoard.SudokuBoard board, SudokuSquare baseSquare)
        {
            var squares = board.sudokuSquares.Where(square => square.x == baseSquare.x - 1 || square.x == baseSquare.x || square.x == baseSquare.x + 1).ToArray();
            squares = squares.Where(square => square.y == baseSquare.y - 1 || square.y == baseSquare.y || square.y == baseSquare.y + 1).ToArray();
            return ExtractNumnbersFromArray(squares);

        }

        //Generate a list of possible numbers for that square
        private void generatepossibleValue(List<int> notPossiblenumbers, SudokuSquare square)
        {
            foreach(int number in NeededNumbers)
            {
                if(notPossiblenumbers.Contains(number)&& square.PossibleNumbers.Contains(number))
                {
                    square.PossibleNumbers.RemoveAll(x => x == number);
                }
                else if (!notPossiblenumbers.Contains(number)&& !square.PossibleNumbers.Contains(number))
                {
                    square.PossibleNumbers.Add(number);
                }
            }

            if(square.PossibleNumbers.Count == 1)
            {
                square.value = square.PossibleNumbers[0];
            }
        }

        //Exctract value from all the squares and add that to the impossible list for that square
        private List<int> ExtractNumnbersFromArray(SudokuSquare[] squares)
        {
            List<int> Numbers = new List<int>();
            for(int x = 0; x < squares.Length; x++)
            {
                if(squares[x].value != 0)
                {
                    Numbers.Add(squares[x].value);
                }
            }
            return Numbers;
        }

        //Inserts value for all squares until all squares are filled
        private void InsertValue(SudokuBoard.SudokuBoard board)
        {
            int totalFilledsquares = 0;
            while (totalFilledsquares < board.sudokuSquares.Length)
            {
                totalFilledsquares = 0;
                foreach (SudokuSquare square in board.sudokuSquares)
                {
                    if (square.value != 0)
                    {
                        totalFilledsquares++;
                    }
                    else if (square.PossibleNumbers.Count == 1)
                    {
                        square.value = square.PossibleNumbers[0];
                        RemovePosibleNumber(board, square);
                        totalFilledsquares++;
                    }
                }
            }
        }

        //Removes possible value after it was filled in a square
        private void RemovePosibleNumber(SudokuBoard.SudokuBoard board, SudokuSquare square)
        {
            List<SudokuSquare> squaresremovepossiblevalue = board.sudokuSquares.Where(square => square.x == square.x).ToList();
            squaresremovepossiblevalue.AddRange(board.sudokuSquares.Where(square => square.y == square.y).ToList());
            foreach(SudokuSquare sudokuSquare in squaresremovepossiblevalue)
            {
                if(sudokuSquare.PossibleNumbers.Contains(square.value))
                {
                    sudokuSquare.PossibleNumbers.RemoveAll(x => x == square.value);
                }
            }
        }
    }
}
