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
    public class ProjectService
    {
        public ProjectBLL GetOne(int Id)
        {
            ProjectRepository pr = new ProjectRepository();
            return pr.GetOne(Id).ToApi();
        }

        public void Create(string nameProject)
        {
            throw new NotImplementedException();
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ProjectEntity project)
        {
            throw new NotImplementedException();
        }
    }
}
