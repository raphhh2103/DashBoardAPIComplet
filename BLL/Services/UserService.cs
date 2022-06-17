using BLL.MapperBLL;
using BLL.Models;
using DashBoardDAL.Entities;
using DashBoardDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {


        public UserBLL GetOne(int id)
        {
            UserRepository ur = new UserRepository();

            return ur.GetOne(id).ToApi();
        }

        public void Create(string email, string pseudo, string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}
