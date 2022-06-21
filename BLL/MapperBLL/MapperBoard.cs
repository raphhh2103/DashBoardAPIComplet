using BLL.Models;
using DashBoardDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperBLL
{
    public static class MapperBoard
    {
        /// <summary>
        /// converti un BoardAPI en BoardEntity
        /// </summary>
        /// <param name="boardAPI"></param>
        /// <returns>boardEntity</returns>
        //public static BoardEntity ToEntity( this BoardBLL boardAPI)
        //{
        //    BoardEntity res = new BoardEntity();

        //    res.Id = boardAPI.Id;
        //    res.Title = boardAPI.Title;
        //    res.UserOwner = MapperUser.ToEntity(boardAPI.UserOwner);
        //    res.Contents = (ICollection<ContentEntity>)boardAPI.Contents;
        //    return res;
        //}
        /// <summary>
        /// converti un board Entity en BoardAPi
        /// </summary>
        /// <param name="boardEntity"></param>
        /// <returns>Board API</returns>
        //public static BoardBLL ToApi( this BoardEntity boardEntity)
        //{
        //    BoardBLL res = new BoardBLL();
        //    res.Id = boardEntity.Id;
        //    res.Title = boardEntity.Title;
        //    res.UserOwner = MapperUser.ToApi(boardEntity.UserOwner);
        //    res.Contents = (IEnumerable<int>)boardEntity.Contents;
        //    return res;
        //}
    }
}
