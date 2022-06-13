using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashBoardAPI.ModelsAPI;
using DashBoardDAL.Entities;

namespace BLL.MapperBLL
{
    internal class MapperProject
    {
        /// <summary>
        /// converti un projectEntity en projectAPI
        /// </summary>
        /// <param name="projectEntity"></param>
        /// <returns>projectAPi</returns>
        public ProjectAPI ToApi (ProjectEntity projectEntity)
        {
            ProjectAPI res = new ProjectAPI ();
            res.Id = projectEntity.Id;
            res.NameProject = projectEntity.NameProject;
            res.TeamUsers = (IEnumerable<UserAPI>)projectEntity.TeamsUsers;

            return res;
        }

        /// <summary>
        /// converti un ProjectAPi en projectEntity
        /// </summary>
        /// <param name="projectAPI"></param>
        /// <returns>project entity</returns>
        public ProjectEntity ToEntity (ProjectAPI projectAPI)
        {
            ProjectEntity res = new ProjectEntity();
            res.Id = projectAPI.Id;
            res.NameProject = projectAPI.NameProject;
            res.TeamsUsers = (IEnumerable<UserEntity>)projectAPI.TeamUsers;
            return res;
        }


    }
}
