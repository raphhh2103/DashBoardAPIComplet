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
        /// <summary>
        /// converti un team entity en teamAPI 
        /// </summary>
        /// <param name="teamEntity"></param>
        /// <returns>teamAPI </returns>
        public TeamAPI ToApi(TeamEntity teamEntity)
        {
            TeamAPI res = new TeamAPI();
            res.Id = teamEntity.Id;
            res.Name = teamEntity.Name;
            res.TeamUsers = (IEnumerable<UserAPI>)teamEntity.TeamUsers;

            return res;
        }
        /// <summary>
        /// converti unteamAPI  en  team entity
        /// </summary>
        /// <param name="teamAPI"></param>
        /// <returns>teamEntity</returns>
        public TeamEntity ToEntity(TeamAPI teamAPI)
        {
            TeamEntity res = new TeamEntity();
            res.Id = teamAPI.Id;
            res.Name=teamAPI.Name;
            res.TeamUsers = (IEnumerable<TeamEntity>)teamAPI.TeamUsers;

        }
    }
}
