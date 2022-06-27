using BLL.MapperBLL;
using BLL.Models;
using DashBoardDAL.Entities;
using DashBoardDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BoardService
    {
        public BoardBLL GetOne(int id)
        {
            BoardRepository br = new BoardRepository();
            return br.GetOne(id).ToBll();
        }

        public void Create(string title, UserBLL userOwner)
        {
            throw new NotImplementedException();
        }

        public object GetAll()
        {
            return null;
        }

        public void Update(BoardEntity board)
        {
            throw new NotImplementedException();
        }
    }
}
