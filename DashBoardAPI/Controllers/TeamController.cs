using DashBoardDAL.Entities;
using DashBoardDAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DashBoardAPI.Controllers
{
    [ApiController]
    [Route("Team")]
    public class TeamController : ControllerBase
    {

        TeamRepository tr = new TeamRepository();

        [HttpPost]
        public IActionResult CreateTeam(TeamEntity team)
        {
            tr.Create(team.Name);


            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetOneTeam(int id)
        {
            tr.GetOne(id);

            return Ok();
        }
        [HttpGet]
        public IActionResult GetAllTeam()
        {
            return Ok(tr.GetAll());
        }
        [HttpPut("{team}")]
        public IActionResult UpdateTeam(TeamEntity team)
        {
            tr.Update(team);

            return Ok();
        }
    }
}
