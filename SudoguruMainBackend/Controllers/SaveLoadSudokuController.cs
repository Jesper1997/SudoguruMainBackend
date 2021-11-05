using Microsoft.AspNetCore.Mvc;
using SudoguruMainBackend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SudoguruMainBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaveLoadSudokuController : Controller
    {

        private readonly DALSudoku.DalSudoku dal;
        private readonly Converter.ISudokuConverter converter;

        public SaveLoadSudokuController(DALSudoku.DalSudoku dal, Converter.ISudokuConverter converter )
        {
            this.dal = dal;
            this.converter = converter;
        }

        [HttpPost]
        [Route("save")]
        public IActionResult SaveBoard([FromBody] BoardViewModel receivedboard)
        {
            try
            {
                var board = converter.BoardConverter(receivedboard);
                dal.SaveSudoku(board);
                return Ok();
            }
            catch
            {
                return new BadRequestObjectResult(415);
            }
        }

        [HttpGet]
        [Route("load/{id}")]
        public IActionResult LoadBoard([FromRoute] int id)
        {
            try
            {
                var board = dal.GetSudoku(id);
                if (board != null)
                {
                    return Ok(board);
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return NotFound();
            }
        }



        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
