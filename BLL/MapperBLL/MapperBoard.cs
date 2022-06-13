using DashBoardAPI.ModelsAPI;
using DashBoardDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperBLL
{
    internal class MapperBoard
    {
        /// <summary>
        /// converti un BoardAPI en BoardEntity
        /// </summary>
        /// <param name="boardAPI"></param>
        /// <returns>boardEntity</returns>
        public BoardEntity ToEntity(BoardAPI boardAPI)
        {
            BoardEntity res = new BoardEntity();
            MapperUser mu = new MapperUser();

            res.Id = boardAPI.Id;
            res.Title = boardAPI.Title;
            res.UserOwner = mu.ToEntity(boardAPI.UserOwner);
            res.Contents = (IEnumerable<ContentEntity>)boardAPI.Contents;
            return res;
        }
        /// <summary>
        /// converti un board Entity en BoardAPi
        /// </summary>
        /// <param name="boardEntity"></param>
        /// <returns>Board API</returns>
        public BoardAPI ToApi(BoardEntity boardEntity)
        {
            BoardAPI res = new BoardAPI();
            MapperUser mu = new MapperUser();
            res.Id = boardEntity.Id;
            res.Title = boardEntity.Title;
            res.UserOwner = mu.ToApi(boardEntity.UserOwner);
            res.Contents = (IEnumerable<ContentAPI>)boardEntity.Contents;
            return res;
        }
    }
}
