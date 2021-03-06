
using BLL.Models;
using BLL.Services;
using DashBoardAPI.MapperAPI;
using DashBoardAPI.ModelsAPI;
using DashBoardAPI.Services;
using DashBoardDAL.Entities;
using DashBoardDAL.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DashBoardAPI.Controllers
{
    [ApiController]
    [Route("User")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController( UserService userService)
        {
            _userService = userService;
        }
 

        [HttpPost]
        public IActionResult UserCreate(UserAPI user)
        {
            byte[] salt = Crypto.GenerateSalt();
            user.Salt = Convert.ToBase64String(salt);
            UserBLL u = user.ToBll();
            u.PassWord = Encoding.ASCII.GetBytes( Crypto.AshPassword(salt, user.PassWord));

            _userService.Create(u, salt);

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
            
            IEnumerable<UserAPI> userAllData = _userService.GetAll().Select(u=>u.ToApi());
            IEnumerable<object> userEssentialData = userAllData.Select(u => new {u.Id ,u.Email,u.Pseudo,});
            return Ok(userEssentialData);
        }

        [HttpPut("{user}")]
        public IActionResult UpdateUser(UserEntity user)
        {

            _userService.Update(user);

            //    //foireux ! 
            return Ok();
        }

    }
}
