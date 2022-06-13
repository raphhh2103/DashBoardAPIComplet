﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashBoardAPI.ModelsAPI;
using DashBoardDAL.Entities;

namespace BLL.MapperBLL
{
    internal class MapperContent
    {
        public ContentAPI ToApi(ContentEntity contentEntity)
        {
            ContentAPI res = new ContentAPI();
            MapperBoard MB = new MapperBoard();
            res.Id = contentEntity.Id;
            res.Text = contentEntity.Text;
            res.TitleBoard = MB.ToApi(contentEntity.TitleBoard);
            return res;
        }
        public ContentEntity ToEntity(ContentAPI contentAPI)
        {
            ContentEntity res = new ContentEntity();
            MapperBoard MB = new MapperBoard();
            res.Id = contentAPI.Id;
            res.Text = contentAPI.Text;
            res.TitleBoard = MB.ToEntity(contentAPI.TitleBoard);
            return res;
        }

    }
}