using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryAlgorithm;
using System.Net.Http;
using SudoguruMainBackend.ViewModels;
using SudoguruMainBackend.Converter;

namespace SudoguruMainBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SolutionController : Controller
    {
        private readonly ISudokuConverter converter;

        public SolutionController(ISudokuConverter converter)
        {
            this.converter = converter;
        }

        [HttpPost]
        [Route("BasicCheck")]
        public IActionResult BasicCheck([FromBody] BoardViewModel receivedboard)
        {
            try
            {
                GenerateAlgorithmCheckSudoku factory = new GenerateAlgorithmCheckSudoku();
                var sudokuCheck = factory.GetCheckAlgorithme;
                SudokuBoard.SudokuBoard board = converter.BoardConverter(receivedboard);
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
            try
            {
                SudokuSolutionCreatorFactory factory = new SudokuSolutionCreatorFactory();
                var sudokuSulutionCreator = factory.GetCheckAlgorithme;
                SudokuBoard.SudokuBoard board = converter.BoardConverter(receivedboard);
                //dal.SaveSudoku(board);

                sudokuSulutionCreator.CreateSolution(board);

                return Ok(sudokuSulutionCreator.CreateSolution(board));
            }
            catch { return new BadRequestObjectResult(415);}
        }



    }
}
