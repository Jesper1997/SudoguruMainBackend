using System;
using System.Collections.Generic;
using System.Text;

namespace IDAlSudoku
{
    public interface IDalSudoku
    {
        public void SaveSudoku(SudokuBoard.SudokuBoard board);

        public SudokuBoard.SudokuBoard GetSudoku(int id);
    }
}
