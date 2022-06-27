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
        private readonly ContentRepository _contentRepository;
        public ContentService(ContentRepository contentRepository)
        {
            this._contentRepository = contentRepository;
        }


        public ContentEntity Create(ContentBLL be, string text)
        {
           return _contentRepository.Create(be.ToEntity(), text);
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ContentEntity content)
        {
            throw new NotImplementedException();
        }

        public ContentBLL GetOne(int id)
        {
           return _contentRepository.GetOne(id).ToApi();
        }
    }
}
