
using BLL.Models;
using BLL.Services;
using DashBoardAPI.MapperAPI;
using DashBoardAPI.ModelsAPI;
using DashBoardAPI.Services;
using DashBoardDAL.Entities;
using DashBoardDAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DashBoardAPI.Controllers
{
    [ApiController]
    [Route("User")]
    public class UserController : ControllerBase
    {
        //Context.Context c = new Context.Context();
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult UserCreate(UserAPI user)
        {
            byte[] salt = Crypto.GenerateSalt();
            UserBLL u = user.ToBll();

            u.PassWord = Crypto.AshPassword(salt, user.PassWord);

            _userService.Create(u.T, salt);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetOneUser(int id)
        {
            return Ok(_userService.GetOne(id));
        }
        [HttpGet]
        public IActionResult GetAllUser()
        {
            return Ok(_userService.GetAll());
        }

        //[HttpPut("{user}")]
        //public IActionResult UpdateUser(UserEntity user)
        //{
            
        //    ur.Update(user);

        //    //foireux ! 
        //    return Ok();
        //} 

    }
}
