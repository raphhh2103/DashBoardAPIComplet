using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashBoardAPI.ModelsAPI;
using DashBoardDAL.Entities;

namespace BLL.MapperBLL
{
    internal class MapperTeam
    {

        public TeamAPI ToApi(TeamEntity teamEntity)
        {
            TeamAPI res = new TeamAPI();
            res.Id = teamEntity.Id;
            res.Name = teamEntity.Name;
            res.TeamUsers = (IEnumerable<UserAPI>)teamEntity.TeamUsers;

            return res;
        }
    }
}
