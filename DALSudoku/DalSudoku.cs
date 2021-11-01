using System;
using EFMyDBContext;

namespace DALSudoku
{
    public class DalSudoku
    {
        private readonly DBContext context;

        public DalSudoku(DBContext dB)
        {
            context = dB;
        }
        public void SaveSudoku (SudokuBoard.SudokuBoard board)
        {
            context.sudokuBoards.Add(board);
            context.SaveChanges();
        }
    }
}
