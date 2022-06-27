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
<<<<<<< HEAD
        public static UserEntity ToDal(this UserBLL userBLL)
        {
            UserEntity userEntity = new UserEntity();
            userEntity.Id = userBLL.Id;
            userEntity.Pseudo = userBLL.Pseudo;
            userEntity.Email = userBLL.Email;
            userEntity.PssWd = userBLL.PassWord;
            userEntity.Salt = userBLL.Salt;
            userEntity.Boards = (ICollection<BoardEntity>)userBLL.Boards;
            userEntity.Teams = (ICollection<TeamEntity>)userBLL.Teams;
            

=======
        public static UserEntity ToEntity(this UserBLL userBLL)
        {
            UserEntity res = new UserEntity();
            BoardService bs = new BoardService();
            TeamService ts = new TeamService();
            res.Id = userBLL.Id;
            res.Pseudo = userBLL.Pseudo;
            res.Email = userBLL.Email;
            res.PssWd = userBLL.PassWord;
            //res.Boards = new List<BoardEntity>();
>>>>>>> 9b4b8d11ee1ac5294b585e0a2a82d2e118d303b0
            //foreach (var item in userAPI.Boards)
            //{
            //    res.Boards.Add(MapperBoard.ToEntity(bs.GetOne(item))) /*userAPI.Boards*/;
            //}
            //res.Boards = (IEnumerable<BoardEntity>)userAPI.Boards;
            //res.Teams = (IEnumerable<TeamEntity>)userAPI.Teams;
            return userEntity;
        }
        /// <summary>
        /// converti un userEntity en UserApi
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns>UserApi</returns>
<<<<<<< HEAD
        public static UserBLL ToBll(this UserEntity userEntity)
=======
        public static UserBLL ToBLL(this UserEntity userEntity)
>>>>>>> 9b4b8d11ee1ac5294b585e0a2a82d2e118d303b0
        {
            UserBLL userBLL = new UserBLL();
            userBLL.Id = userEntity.Id;
            userBLL.Pseudo = userEntity.Pseudo;
            userBLL.Email = userEntity.Email;
            userBLL.PassWord = userEntity.PssWd;
            userBLL.Salt = userEntity.Salt;
            userBLL.Teams = (ICollection<TeamBLL>)userEntity.Teams;
            userBLL.Boards = (ICollection<BoardBLL>)userEntity.Boards;

            //foireux
            //res.Boards = userEntity.Boards.Select(d => d.Id)/*.ToApi()*/;
            //res.Boards = userEntity.Boards.All(d=> d.UserOwner.Id == userEntity.Id?d.Id:0);
<<<<<<< HEAD

            //res.Boards = (ICollection<int>)userEntity.Boards.Select(b=>b.Id);

            //res.Teams = userEntity.Teams.Select(d => d.Id);
=======
            //res.Boards = userEntity.Boards.Select(b=>b.Id);
            
          //  res.Teams = userEntity.Teams.Select(d => d.Id);
>>>>>>> 9b4b8d11ee1ac5294b585e0a2a82d2e118d303b0
            //res.Boards = (IEnumerable<BoardBLL>)userEntity.Boards;
            //res.Teams = (IEnumerable<TeamBLL>)userEntity.Teams;
            return userBLL;

        }


    }
}
