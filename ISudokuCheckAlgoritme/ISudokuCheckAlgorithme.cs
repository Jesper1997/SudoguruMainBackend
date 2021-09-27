using System;
using System.Collections.Generic;
using System.Text;
using ISudokuCheckAlgoritme;

namespace ISudokuCheckAlgoritme
{
    public interface ISudokuCheckAlgorithme
    {
        public ISudokuCheckAlgoritme.ISudokuCheckAlgorithme SudokuSetUpForControlle(SudokuBoard.SudokuBoard board);
    }
}
