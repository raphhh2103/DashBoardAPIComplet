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
        private readonly UserRepository _userService;

        public UserService(UserRepository userRepository)
        {
            this._userService = userRepository;
        }

        public UserBLL GetOne(int id)
        {
    

            return _userService.GetOne(id).ToBLL();
        }

        public bool Create(UserBLL user, byte[] salt)
        {
            
            UserEntity entity = user.ToEntity();
            entity.Salt = Encoding.UTF8.GetString(salt);
            return _userService.Create(entity, user.Teams);
        }

        public IEnumerable<UserBLL> GetAll()
        {
            return _userService.GetAll().Select(u=> u.ToBLL());

        }

        public void Update(UserEntity user)
        {
            _userService.Update(user);
        }
    }
}
