using BLL.Models;
using BLL.Services;
using DashBoardDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperBLL
{
    public static class MapperUser
    {
        /// <summary>
        /// converti un userAPI en UserEntity 
        /// </summary>
        /// <param name="userBLL"></param>
        /// <returns> UserEntity</returns>
        public static UserEntity ToEntity(this UserBLL userBLL)
        {
            UserEntity res = new UserEntity();

            res.Id = userBLL.Id;
            res.Pseudo = userBLL.Pseudo;
            res.Email = userBLL.Email;
            res.PssWd = userBLL.PassWord;

            return res;
        }
        /// <summary>
        /// converti un userEntity en UserApi
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns>UserApi</returns>
        public static UserBLL ToBLL(this UserEntity userEntity)
        {
            UserBLL userBLL = new UserBLL();
            userBLL.Id = userEntity.Id;
            userBLL.Pseudo = userEntity.Pseudo;
            userBLL.Email = userEntity.Email;
            userBLL.PassWord = userEntity.PssWd;
            userBLL.Salt = userEntity.Salt;
            userBLL.Teams = (ICollection<TeamBLL>)userEntity.Teams;
            userBLL.Boards = (ICollection<BoardBLL>)userEntity.Boards;

            return userBLL;

        }


    }
}
