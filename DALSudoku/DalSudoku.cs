using System;
using System.Linq;
using EFMyDBContext;
using IDAlSudoku;
using Microsoft.EntityFrameworkCore;

namespace DALSudoku
{
    public class DalSudoku : IDalSudoku
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

        public SudokuBoard.SudokuBoard GetSudoku(int id)
        {
            SudokuBoard.SudokuBoard board = (SudokuBoard.SudokuBoard)context.sudokuBoards.Include(s => s.sudokuSquares).FirstOrDefault(x => x.Id == id); /*context.sudokuBoards.Find(id);*/


            return board;
        }
    }
}
