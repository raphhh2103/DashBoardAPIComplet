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
    public class ContentService
    {

        //public ContentBLL GetOne(int id)
        //{
        //    ContentRepository cr = new ContentRepository();
        //    return cr.GetOne(id).ToApi();
        //}

        public void Create(BoardEntity be, string text)
        {
            throw new NotImplementedException();
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ContentEntity content)
        {
            throw new NotImplementedException();
        }
    }
}
