using DashBoardDAL.Entities;
using DashBoardDAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DashBoardAPI.Controllers
{
    public class ProjectController : ControllerBase
    {

        ProjectRepository pr = new ProjectRepository(); 

        [HttpPost]
        public IActionResult CreateProject(ProjectEntity pe)
        {
            pr.Create(pe.NameProject);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetOneProject(int id)
        {
            pr.GetOne(id);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllProject()
        {
            return Ok(pr.GetAll());
        }
        [HttpPut("{project}")]
        public IActionResult UpdateProject(ProjectEntity project)
        {
            pr.Update(project);

            return Ok();
        }

    }
}
