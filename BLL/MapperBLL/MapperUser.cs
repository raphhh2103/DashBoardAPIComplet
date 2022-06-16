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
        /// <param name="userAPI"></param>
        /// <returns> UserEntity</returns>
        public static UserEntity ToEntity(this UserBLL userAPI)
        {
            UserEntity res = new UserEntity();
            BoardService bs = new BoardService();
            TeamService ts = new TeamService();
            res.Id = userAPI.Id;
            res.Pseudo = userAPI.Pseudo;
            res.Email = userAPI.Email;
            res.PssWd = userAPI.PassWord;
            foreach (var item in userAPI.Boards)
            {
                res.Boards.ToList().Add(MapperBoard.ToEntity(bs.GetOne(item))) /*userAPI.Boards*/;
            }
            foreach (var item in userAPI.Teams)
            {
                res.Teams.ToList().Add(MapperTeam.ToEntity(ts.GetOne(item)));
            }
            //res.Boards = (IEnumerable<BoardEntity>)userAPI.Boards;
            //res.Teams = (IEnumerable<TeamEntity>)userAPI.Teams;
            return res;
        }
        /// <summary>
        /// converti un userEntity en UserApi
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns>UserApi</returns>
        public static UserBLL ToApi(this UserEntity userEntity)
        {
            UserBLL res = new UserBLL();
            res.Id = userEntity.Id;
            res.Pseudo = userEntity.Pseudo;
            res.Email = userEntity.Email;
            res.PassWord = userEntity.PssWd;
            res.Boards = userEntity.Boards.Select(d => d.Id)/*.ToApi()*/;
            res.Teams = userEntity.Teams.Select(d => d.Id);
            //res.Boards = (IEnumerable<BoardBLL>)userEntity.Boards;
            //res.Teams = (IEnumerable<TeamBLL>)userEntity.Teams;
            return res;
        }


    }
}
