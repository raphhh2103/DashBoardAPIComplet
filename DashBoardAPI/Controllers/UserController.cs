﻿
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
        UserService ur = new UserService();

        [HttpPost]
        public IActionResult UserCreate(UserAPI user)
        {
            byte[] s = Crypto.GenerateSalt();
            UserBLL u = user.ToBll();

            u.PassWord = Crypto.AshPassword(s, user.PassWord);
            
            ur.Create(u, s);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetOneUser(int id)
        {
            return Ok(ur.GetOne(id));
        }
        [HttpGet]
        public IActionResult GetAllUser()
        {
            return Ok(ur.GetAll());
        }

        [HttpPut("{user}")]
        public IActionResult UpdateUser(UserEntity user)
        {
            
            ur.Update(user);

            //foireux ! 
            return Ok();
        } 

    }
}
