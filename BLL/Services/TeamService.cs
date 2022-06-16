using BLL.MapperBLL;
using BLL.Models;
using DashBoardDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TeamService
    {
        public TeamBLL GetOne(int id)
        {
            TeamRepository  tr = new TeamRepository();
            return  tr.GetOne(id).ToApi();
        }

        public void Create(string name)
        {
            throw new NotImplementedException();
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
