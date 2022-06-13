using DashBoardAPI.ModelsAPI;
using DashBoardDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperBLL
{
    internal class MapperUser
    {
        /// <summary>
        /// converti un userAPI en UserEntity 
        /// </summary>
        /// <param name="userAPI"></param>
        /// <returns> UserEntity</returns>
        public UserEntity ToEntity (UserAPI userAPI)
        {
            UserEntity res = new UserEntity();
            res.Id = userAPI.Id;
            res.Pseudo = userAPI.Pseudo;
            res.Email = userAPI.Email;
            res.PssWd = userAPI.PassWord;
            res.Boards = (IEnumerable<BoardEntity>)userAPI.Boards;
            res.Teams = (IEnumerable<TeamEntity>)userAPI.Teams;
            return res;
        }
        /// <summary>
        /// converti un userEntity en UserApi
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns>UserApi</returns>
        public UserAPI ToApi(UserEntity userEntity)
        {
            UserAPI res = new UserAPI();
            res.Id = userEntity.Id;
            res.Pseudo = userEntity.Pseudo;
            res.Email = userEntity.Email;
            res.PassWord = userEntity.PssWd;
            res.Boards = (IEnumerable<BoardAPI>)userEntity.Boards;
            res.Teams = (IEnumerable<TeamAPI>)userEntity.Teams;
            return res;
        }


    }
}
