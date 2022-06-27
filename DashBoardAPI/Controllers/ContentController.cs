using BLL.Services;
using DashBoardAPI.MapperAPI;
using DashBoardAPI.ModelsAPI;
using DashBoardDAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DashBoardAPI.Controllers
{
    [ApiController]
    [Route("Content")]
    public class ContentController : ControllerBase
    {
        private readonly ContentService _contentService;

        public ContentController(ContentService contentService)
        {
            this._contentService = contentService;
        }

        [HttpPost]
        public IActionResult ContentCreate( ContentAPI contentAPI)
        {
           
    
            _contentService.Create(contentAPI.ToBll(), "default");

            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetOneContent(int id)
        {
            return Ok(_contentService.GetOne(id));
        }
        [HttpGet]
        public IActionResult GetAllContent()
        {
            return Ok(_contentService.GetAll());
        }
        [HttpPut("{Content}")]
        public IActionResult UpdateContent(ContentEntity content)
        {
            _contentService.Update(content);

            return Ok();
        }

    }
}
