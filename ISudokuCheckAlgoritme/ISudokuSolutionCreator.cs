using System;
using System.Collections.Generic;
using System.Text;

namespace ISudokuCheckAlgoritme
{
    public interface ISudokuSolutionCreator
    {
        public SudokuBoard.SudokuBoard CreateSolution(SudokuBoard.SudokuBoard board);
    }
}
