using BLL.MapperBLL;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashBoardDAL.Repositories;
using DashBoardDAL.Entities;

namespace BLL.Services
{
    public class UserService
    {
        private readonly UserRepository _userService;

        public UserService(UserRepository userRepository)
        {
            this._userService = userRepository;
        }

        public UserBLL GetOne(int id)
        {


            return _userService.GetOne(id).ToBLL();
            return null;
        }

     

        public UserEntity Create(UserBLL user, byte[] salt)
        {

            //UserEntity entity = user.ToEntity();
            //entity.Salt = Encoding.UTF8.GetString(salt);
            user.Salt = salt;
            return _userService.Create(user.ToEntity()/*, user.Teams*/);
            //return null;
        }

        public IEnumerable<UserBLL> GetAll()
        {
            //return _userService.GetAll().Select(u=> u.ToBLL());
            return null;

        }

        public void Update(UserEntity user)
        {
            //_userService.Update(user);
            //return null;
        }
    }
}
