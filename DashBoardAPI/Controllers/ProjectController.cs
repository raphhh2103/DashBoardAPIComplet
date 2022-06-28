using BLL.Services;
using DashBoardDAL.Entities;
using DashBoardDAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DashBoardAPI.Controllers
{
    [ApiController]
    [Route("Project")]
    public class ProjectController : ControllerBase
    {

        private readonly ProjectService _projectService;
        public ProjectController(ProjectService projectService)
        {
            this._projectService = projectService;
        }

        [HttpPost]
        public IActionResult CreateProject(ProjectEntity pe)
        {
            _projectService.Create(pe.NameProject);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetOneProject(int id)
        {
            _projectService.GetOne(id);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllProject()
        {
            return Ok(_projectService.GetAll());
        }
        [HttpPut("/{project}")]
        public IActionResult UpdateProject(ProjectEntity project)
        {
            _projectService.Update(project);

            return Ok();
        }

    }
}
