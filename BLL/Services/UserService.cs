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
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UserBLL> GetAll()
        {
            return _userRepository.GetAll().Select(u => u.ToBll());
        }

        public UserBLL GetOne(int id)
        {


            return _userRepository.GetOne(id).ToBll();
        }

        // I love Dicks (Jean Timmermans) 

        public UserEntity Create(UserBLL user, byte[] salt)
        {
            user.Salt = Convert.ToBase64String(salt);
            return _userRepository.Create(user.ToDal());
        }

        //public IEnumerator<UserBLL> GetAll()
        //{

        //    UserRepository ur = new UserRepository();
        //    ICollection<UserBLL> list = new List<UserBLL>();
        //    foreach (UserEntity user in ur.GetAll())
        //    {
        //        list.Add(user.ToApi());
        //    }
        //     //ur.GetAll();

        //    return (IEnumerator<UserBLL>)list;

        //}

        //public void Update(UserEntity user)
        //{
        //    UserRepository ur =new UserRepository();
        //    ur.Update(user);
        //}
    }
}
