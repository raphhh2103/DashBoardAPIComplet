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
        public readonly TeamRepository _teamRepository;
        public TeamService(TeamRepository teamRepository)
        {
            this._teamRepository = teamRepository;
        }

        public TeamBLL GetOne(int id)
        {
            //return _teamRepository.GetOne(id).ToApi();
            return null;
        }

        public TeamBLL Create(string name)
        {
            //return _teamRepository.Create(name).ToApi();
            return null;
        }

        public IEnumerable<TeamBLL> GetAll()
        {
            //return _teamRepository.GetAll().Select(t=>t.ToApi());
            return null;
        }

        public void Update(TeamBLL team)
        {
           
        }
    }
}
