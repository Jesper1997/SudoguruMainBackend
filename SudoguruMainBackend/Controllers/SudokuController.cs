using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryAlgorithm;
using System.Net.Http;
using SudoguruMainBackend.ViewModels;

namespace SudoguruMainBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SudokuController : Controller
    {
        private readonly DALSudoku.DalSudoku dal;

        public SudokuController(DALSudoku.DalSudoku dal)
        {
            this.dal = dal;
        }

        [HttpPost]
        [Route("BasicCheck")]
        public IActionResult BasicCheck([FromBody] BoardViewModel receivedboard)
        {
            try
            {
                GenerateAlgorithmCheckSudoku factory = new GenerateAlgorithmCheckSudoku();
                var sudokuCheck = factory.GetCheckAlgorithme;
                SudokuBoard.SudokuBoard board = BoardConverter(receivedboard);
                sudokuCheck.SudokuSetUpForControlle(board);

                return Ok(sudokuCheck.SudokuSetUpForControlle(board));
            }
            catch
            {
                return new BadRequestResult();
            }
        }

        [HttpPost]
        [Route("CreateSolution")]
        public IActionResult CreateSolution([FromBody] BoardViewModel receivedboard)
        {
            if(receivedboard.squares == null)
            {
                return new BadRequestObjectResult(415);
            }
            //try
            //{
                SudokuSolutionCreatorFactory factory = new SudokuSolutionCreatorFactory();
                var sudokuSulutionCreator = factory.GetCheckAlgorithme;
                SudokuBoard.SudokuBoard board = BoardConverter(receivedboard);

                dal.SaveSudoku(board);

                sudokuSulutionCreator.CreateSolution(board);

                return Ok(sudokuSulutionCreator.CreateSolution(board));
            //}
            //catch { return new BadRequestObjectResult(415); }
        }


        private SudokuBoard.SudokuBoard BoardConverter(BoardViewModel receivedboard)
        {
            List<SudokuBoard.SudokuSquare> squares = new List<SudokuBoard.SudokuSquare>();
            SudokuBoard.SudokuBoard board = new SudokuBoard.SudokuBoard();
            for (int x = 0; x < receivedboard.squares.Length; x++)
            {
                SudokuBoard.SudokuSquare sudokuSquare = new SudokuBoard.SudokuSquare
                {
                    x = receivedboard.squares[x].x,
                    y = receivedboard.squares[x].y,
                    SquareId = receivedboard.squares[x].id,
                    value = receivedboard.squares[x].value
                };
                squares.Add(sudokuSquare);
            }
            board.sudokuSquares = squares;
            return board;
        }
    }
}
