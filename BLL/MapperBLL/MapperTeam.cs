using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using DashBoardDAL.Entities;


namespace BLL.MapperBLL
{
    public static class MapperTeam
    {
        /// <summary>
        /// converti un team entity en teamAPI 
        /// </summary>
        /// <param name="teamEntity"></param>
        /// <returns>teamAPI </returns>
        public static TeamBLL ToApi(this TeamEntity teamEntity)
        {
            TeamBLL res = new TeamBLL();
            res.Id = teamEntity.Id;
            res.Name = teamEntity.Name;
            res.TeamUsers = (IEnumerable<int>)teamEntity.TeamUsers.Select(t => t.Id);

            return res;
        }
        /// <summary>
        /// converti unteamAPI  en  team entity
        /// </summary>
        /// <param name="teamAPI"></param>
        /// <returns>teamEntity</returns>
        public static TeamEntity ToEntity(this TeamBLL teamAPI)
        {
            TeamEntity res = new TeamEntity();
            res.Id = teamAPI.Id;
            res.Name=teamAPI.Name;
            //res.TeamUsers = (IEnumerable<UserEntity>)teamAPI.TeamUsers;

            return res ;
        }
    }
}
