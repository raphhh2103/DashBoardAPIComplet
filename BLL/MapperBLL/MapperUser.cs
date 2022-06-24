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
            BoardService bs = new BoardService();
            TeamService ts = new TeamService();
            res.Id = userBLL.Id;
            res.Pseudo = userBLL.Pseudo;
            res.Email = userBLL.Email;
            res.PssWd = userBLL.PassWord;
            //res.Boards = new List<BoardEntity>();
            //foreach (var item in userAPI.Boards)
            //{
            //    res.Boards.Add(MapperBoard.ToEntity(bs.GetOne(item))) /*userAPI.Boards*/;
            //}
            //res.Boards = (IEnumerable<BoardEntity>)userAPI.Boards;
            //res.Teams = (IEnumerable<TeamEntity>)userAPI.Teams;
            return res;
        }
        /// <summary>
        /// converti un userEntity en UserApi
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns>UserApi</returns>
        public static UserBLL ToBLL(this UserEntity userEntity)
        {
            UserBLL res = new UserBLL();
            res.Id = userEntity.Id;
            res.Pseudo = userEntity.Pseudo;
            res.Email = userEntity.Email;
            res.PassWord = userEntity.PssWd;
            //foireux
            //res.Boards = userEntity.Boards.Select(d => d.Id)/*.ToApi()*/;
            //res.Boards = userEntity.Boards.All(d=> d.UserOwner.Id == userEntity.Id?d.Id:0);
            //res.Boards = userEntity.Boards.Select(b=>b.Id);
            
          //  res.Teams = userEntity.Teams.Select(d => d.Id);
            //res.Boards = (IEnumerable<BoardBLL>)userEntity.Boards;
            //res.Teams = (IEnumerable<TeamBLL>)userEntity.Teams;
            return res;

        }


    }
}
