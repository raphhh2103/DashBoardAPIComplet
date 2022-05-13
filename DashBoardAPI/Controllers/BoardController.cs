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
        BoardRepository br = new BoardRepository();


        [HttpPost]
        public IActionResult BoardCreate(BoardEntity board)
        {
            UserEntity user = new UserEntity();
            br.Create(board.Title,user);

            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetOneBoard(int id)
        {
            return Ok(br.GetOne(id));
        }
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
