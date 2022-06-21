using BLL.Services;
using DashBoardDAL.Entities;
using DashBoardDAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DashBoardAPI.Controllers
{
    [ApiController]
    [Route("Board")]
    public class BoardController : ControllerBase
    {
        BoardService br = new BoardService();


        [HttpPost]
        public IActionResult BoardCreate(BoardEntity board)
        {
            UserEntity user = new UserEntity();
            br.Create(board.Title,board.UserOwner);

            return Ok();
        }
        //[HttpGet("{id}")]
        //public IActionResult GetOneBoard(int id)
        //{
        //    return Ok(br.GetOne(id));
        //}
        [HttpGet]
        public IActionResult GetAllBoard()
        {
            return Ok(br.GetAll());
        }
        [HttpPut("{Board}")]
        public IActionResult UpdateBoard(BoardEntity board)
        {
            br.Update(board);

            return Ok();
        }
    }
}
