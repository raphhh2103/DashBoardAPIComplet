using BLL.Services;
using DashBoardDAL.Entities;
using DashBoardDAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DashBoardAPI.Controllers
{
    [ApiController]
    [Route("Content")]
    public class ContentController : ControllerBase
    {
        ContentService cr = new ContentService();

        [HttpPost]
        public IActionResult ContentCreate( BoardEntity be)
        {
            ContentEntity ce = new ContentEntity();
            cr.Create(be, ce.Text);

            return Ok();
        }
        //[HttpGet("{id}")]
        //public IActionResult GetOneContent(int id)
        //{
        //    return Ok(cr.GetOne(id));
        //}
        [HttpGet]
        public IActionResult GetAllContent()
        {
            return Ok(cr.GetAll());
        }
        [HttpPut("{Content}")]
        public IActionResult UpdateContent(ContentEntity content)
        {
            cr.Update(content);

            return Ok();
        }

    }
}
