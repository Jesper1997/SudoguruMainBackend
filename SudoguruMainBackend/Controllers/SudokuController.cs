using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryAlgorithm;
using System.Net.Http;

namespace SudoguruMainBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SudokuController : Controller
    {
        [HttpPost]
        public IActionResult Basiccheck([FromBody] SudokuBoard.SudokuBoard board)
        {
            GenerateAlgorithmCheckSudoku factory = new GenerateAlgorithmCheckSudoku();
            var sudokuCheck = factory.GetCheckAlgorithme;
            sudokuCheck.SudokuSetUpForControlle(board);
            
            return View();
        }

        [HttpPost]
        [Route("CreateSolution")]
        public IActionResult CreateSolution([FromBody] ViewModels.BoardViewModel receivedboard)
        {
            if(receivedboard == null)
            {
                return new BadRequestObjectResult(415);
            }
            try
            {
                SudokuSolutionCreatorFactory factory = new SudokuSolutionCreatorFactory();
                var sudokuSulutionCreator = factory.GetCheckAlgorithme;
                List<SudokuBoard.SudokuSquare> squares = new List<SudokuBoard.SudokuSquare>();
                SudokuBoard.SudokuBoard board = new SudokuBoard.SudokuBoard();
                for(int x = 0; x < receivedboard.squares.Length; x++)
                {
                    SudokuBoard.SudokuSquare sudokuSquare = new SudokuBoard.SudokuSquare
                    {
                        x = receivedboard.squares[x].x,
                        y = receivedboard.squares[x].y,
                        id = receivedboard.squares[x].id,
                        value = receivedboard.squares[x].value
                    };
                    squares.Add(sudokuSquare);
                }
                board.sudokuSquares = squares.ToArray();
                sudokuSulutionCreator.CreateSolution(board);
                return Ok(sudokuSulutionCreator.CreateSolution(board));
            }
            catch { }
            return View();
        }
    }
}
