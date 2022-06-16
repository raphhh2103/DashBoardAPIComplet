using BLL.MapperBLL;
using BLL.Models;
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

    }
}
