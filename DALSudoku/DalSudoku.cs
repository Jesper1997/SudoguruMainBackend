using System;
using EFMyDBContext;

namespace DALSudoku
{
    public class DalSudoku
    {
        public void SaveSudoku (SudokuBoard.SudokuBoard board)
        {
            using(var context = new DBContext())
            {
                context.sudokuBoards.Add(board);
                context.SaveChanges();
            }
        }
    }
}
