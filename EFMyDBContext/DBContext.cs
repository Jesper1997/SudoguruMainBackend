using System;
using SudokuBoard;
using Microsoft.EntityFrameworkCore;

namespace EFMyDBContext
{
    public class DBContext : DbContext
    {
        public DbSet<SudokuBoard.SudokuBoard> sudokuBoards { get; set; }
        public DbSet<SudokuSquare> sudokuSquares { get; set; }

        public DBContext (DbContextOptions<DBContext> options) : base (options)
        {
            //Database.EnsureCreated();
        }

        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            //Map Entities to table
            modelBuilder.Entity<SudokuBoard.SudokuBoard>().ToTable("Boards");
            modelBuilder.Entity<SudokuSquare>().ToTable("Squares");

            //Configure PK
            modelBuilder.Entity<SudokuBoard.SudokuBoard>().HasKey(sb => sb.Id).HasName("PK_Board");
            modelBuilder.Entity<SudokuSquare>().HasKey(table => new { table.id, table.SudokuBoardId }).HasName("PK_Square");

            //Configure Indexes

            //Configure Columns
            //SudokuBoard
            //modelBuilder.Entity<SudokuBoard.SudokuBoard>().Property(sb => sb.Id).UseMySqlIdentityColumn().IsRequired();

            //modelBuilder.Entity<SudokuSquare>().Property(s => s.id).UseMySqlIdentityColumn().IsRequired();
            //modelBuilder.Entity<SudokuSquare>().Property(s => s.x).IsRequired();
            //modelBuilder.Entity<SudokuSquare>().Property(s => s.y).IsRequired();
            //modelBuilder.Entity<SudokuSquare>().Property(s => s.value).IsRequired();
            //modelBuilder.Entity<SudokuSquare>().Property(s => s.BoardId).IsRequired();

        }
    }
}
