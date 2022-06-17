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
        TeamService tr = new TeamService();
        //TeamRepository tr = new TeamRepository();

        [HttpPost]
        public IActionResult CreateTeam(TeamAPI team)
        {
            tr.Create(team.Name);


            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetOneTeam(int id)
        {
           TeamAPI  result =  tr.GetOne(id).ToAPI();

            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetAllTeam()
        {
            return Ok(tr.GetAll());
        }
        [HttpPut("{team}")]
        public IActionResult UpdateTeam(TeamAPI team)
        {
            tr.Update(team);

            return Ok();
        }
    }
}
