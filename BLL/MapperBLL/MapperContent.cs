using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using DashBoardDAL.Entities;

namespace BLL.MapperBLL
{
    public static class MapperContent
    {
        /// <summary>
        /// converti un ContentEntity en ContentAPI
        /// </summary>
        /// <param name="contentEntity"></param>
        /// <returns>content APi</returns>
        public static ContentBLL ToApi(this ContentEntity contentEntity)
        {
            ContentBLL res = new ContentBLL();
            //MapperBoard MB = new MapperBoard();
            res.Id = contentEntity.Id;
            res.Text = contentEntity.Text;
            //res.TitleBoard = ToApi(contentEntity.TitleBoard);
            return res;
        }
        /// <summary>
        /// converti un ContentAPi en Content Entity
        /// </summary>
        /// <param name="contentAPI"></param>
        /// <returns>content entity</returns>
        public static ContentEntity ToEntity(this ContentBLL contentAPI)
        {
            ContentEntity res = new ContentEntity();
            //MapperBoard MB = new MapperBoard();
            res.Id = contentAPI.Id;
            res.Text = contentAPI.Text;
            res.TitleBoard = MapperBoard.ToEntity(contentAPI.TitleBoard);
            return res;
        }

    }
}
