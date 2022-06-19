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

        public bool Create(string email, string pseudo, string v1, string v2)
        {
            UserRepository ur = new UserRepository();
            return ur.Create(email, pseudo, v1, v2);
        }

        public IEnumerator<UserBLL> GetAll()
        {
            UserRepository ur = new UserRepository();
            IEnumerable<UserBLL> list = new List<UserBLL>();
            foreach (UserEntity user in ur.GetAll())
            {
                list.ToList().Add(user.ToApi());
            }
             //ur.GetAll();

            return (IEnumerator<UserBLL>)list;

        }

        public void Update(UserEntity user)
        {
            UserRepository ur =new UserRepository();
            ur.Update(user);
        }
    }
}
