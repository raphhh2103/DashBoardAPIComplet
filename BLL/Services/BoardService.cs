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
            return br.GetOne(id).ToApi();
        }

        public void Create(string title, UserEntity userOwner)
        {
            throw new NotImplementedException();
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(BoardEntity board)
        {
            throw new NotImplementedException();
        }
    }
}
