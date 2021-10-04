using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryAlgorithm;

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
        public IActionResult CreateSolution([FromBody] SudokuBoard.SudokuBoard board)
        {
            SudokuSolutionCreatorFactory factory = new SudokuSolutionCreatorFactory();
            var sudokuSulutionCreator = factory.GetCheckAlgorithme;
            sudokuSulutionCreator.CreateSolution(board);

            return Ok(sudokuSulutionCreator.CreateSolution(board));
        }
    }
}
