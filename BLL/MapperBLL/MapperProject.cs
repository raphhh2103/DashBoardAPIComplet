using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using BLL.Services;
using DashBoardDAL.Entities;

namespace BLL.MapperBLL
{
    public static class MapperProject
    {
        /// <summary>
        /// converti un projectEntity en projectAPI
        /// </summary>
        /// <param name="projectEntity"></param>
        /// <returns>projectAPi</returns>
        public static ProjectBLL ToApi (this ProjectEntity projectEntity)
        {
            ProjectBLL res = new ProjectBLL();
            res.Id = projectEntity.Id;
            res.NameProject = projectEntity.NameProject;
            res.TeamUsers = projectEntity.TeamsUsers.Select(d=> d.Id);
            //res.TeamUsers = (IEnumerable<UserAPI>)projectEntity.TeamsUsers;

            return res;
        }

        /// <summary>
        /// converti un ProjectAPi en projectEntity
        /// </summary>
        /// <param name="projectAPI"></param>
        /// <returns>project entity</returns>
        //public static ProjectEntity ToEntity ( this ProjectBLL projectAPI)
        //{
        //    ProjectEntity res = new ProjectEntity();
        //    res.Id = projectAPI.Id;
        //    res.NameProject = projectAPI.NameProject;
<<<<<<< HEAD
        //    UserService US = new UserService();
=======
>>>>>>> 9b4b8d11ee1ac5294b585e0a2a82d2e118d303b0
        //    //res.TeamsUsers = projectAPI.TeamUsers;
        //    foreach (var item in projectAPI.TeamUsers)
        //    {
        //        res.TeamsUsers.ToList().Add(MapperUser.ToEntity(US.GetOne(item)));
        //    }
        //    //res.TeamsUsers = (IEnumerable<UserEntity>)projectAPI.TeamUsers;
        //    return res;
        //}


    }
}
