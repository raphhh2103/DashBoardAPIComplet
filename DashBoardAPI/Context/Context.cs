﻿using DashBoardDAL.Entities;
using DashBoardDAL.Repositories;

namespace DashBoardAPI.Context
{
    public class Context : IContext
    {
        public UserEntity User { get; set; }
        public TeamEntity Team { get; set; }

        public ProjectEntity Project { get; set; }
        public ContentEntity Content { get; set; }
        public BoardEntity Board { get; set; }
        private UserRepository ur;


        public Context()
        {
            User = new UserEntity()
            {
                Pseudo = "Test",
                PssWd = "Test1234=",
                Email="test@test.be"
            };
             ur = new UserRepository();
        }

        public void CreateUser(UserEntity u)
        {

                ur.Create(u.Pseudo,u.Email,u.PssWd,u.Salt);
        }
       public void GetOneUser(int id)
        {

            ur.GetOne(id);
        }
    }
}