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
        public IActionResult Index([FromBody] SudokuBoard.SudokuBoard board)
        {
            FactoryAlgorithm.GenerateAlgorithmCheckSudoku factory = new FactoryAlgorithm.GenerateAlgorithmCheckSudoku();
            var sudokuCheck = factory.GetCheckAlgorithme;
            sudokuCheck.SudokuSetUpForControlle(board);
            
            return View();
        }
    }
}
