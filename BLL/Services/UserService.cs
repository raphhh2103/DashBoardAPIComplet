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
<<<<<<< HEAD
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UserBLL> GetAll()
        {
            return _userRepository.GetAll().Select(u => u.ToBll());
=======
        private readonly UserRepository _userService;

        public UserService(UserRepository userRepository)
        {
            this._userService = userRepository;
>>>>>>> 9b4b8d11ee1ac5294b585e0a2a82d2e118d303b0
        }

        public UserBLL GetOne(int id)
        {
<<<<<<< HEAD


            return _userRepository.GetOne(id).ToBll();
=======
    

            return _userService.GetOne(id).ToBLL();
>>>>>>> 9b4b8d11ee1ac5294b585e0a2a82d2e118d303b0
        }

        // I love Dicks (Jean Timmermans) 

        public UserEntity Create(UserBLL user, byte[] salt)
        {
<<<<<<< HEAD
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
=======
            
            UserEntity entity = user.ToEntity();
            entity.Salt = Encoding.UTF8.GetString(salt);
            return _userService.Create(entity, user.Teams);
        }

        public IEnumerable<UserBLL> GetAll()
        {
            return _userService.GetAll().Select(u=> u.ToBLL());
>>>>>>> 9b4b8d11ee1ac5294b585e0a2a82d2e118d303b0

        //}

<<<<<<< HEAD
        //public void Update(UserEntity user)
        //{
        //    UserRepository ur =new UserRepository();
        //    ur.Update(user);
        //}
=======
        public void Update(UserEntity user)
        {
            _userService.Update(user);
        }
>>>>>>> 9b4b8d11ee1ac5294b585e0a2a82d2e118d303b0
    }
}
