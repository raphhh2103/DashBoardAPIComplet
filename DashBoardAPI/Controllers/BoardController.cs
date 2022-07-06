using BLL.Services;
using DashBoardAPI.MapperAPI;
using DashBoardAPI.ModelsAPI;
using DashBoardDAL.Entities;
using DashBoardDAL.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DashBoardAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("Board")]
    public class BoardController : ControllerBase
    {
        private readonly BoardService _boardService;

        public BoardController(BoardService boardService)
        {
            this._boardService = boardService;
        }


        [HttpPost]
        public IActionResult BoardCreate(BoardAPI board)
        {
            UserEntity user = new UserEntity();
            _boardService.Create(board.Title,board.UserOwner.ToBll());

            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetOneBoard(int id)
        {
            return Ok(_boardService.GetOne(id));
        }
        [HttpGet]
        public IActionResult GetAllBoard()
        {
            return Ok(_boardService.GetAll());
        }
        [HttpPut("{Board}")]
        public IActionResult UpdateBoard(BoardEntity board)
        {
            _boardService.Update(board);

            return Ok();
        }
    }
}
