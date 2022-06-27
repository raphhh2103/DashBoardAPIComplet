using BLL.Services;
using DashBoardAPI.ModelsAPI;
using DashBoardDAL.Entities;
using DashBoardDAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using DashBoardAPI.MapperAPI;

namespace DashBoardAPI.Controllers
{
    [ApiController]
    [Route("Team")]
    public class TeamController : ControllerBase
    {
        private readonly TeamService _teamServce;

        public TeamController(TeamService teamService)
        {
            this._teamServce = teamService;
        }

        //TeamRepository tr = new TeamRepository();

        [HttpPost]
        public IActionResult CreateTeam(TeamAPI team)
        {
            _teamServce.Create(team.Name);


            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetOneTeam(int id)
        {
           TeamAPI  result = _teamServce.GetOne(id).ToDal();

            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetAllTeam()
        {
            return Ok(_teamServce.GetAll());
        }
        [HttpPut("{team}")]
        public IActionResult UpdateTeam(TeamAPI team)
        {
            _teamServce.Update(team.ToBll());

            return Ok();
        }
    }
}
