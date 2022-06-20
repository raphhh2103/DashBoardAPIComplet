using DashBoardDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Repositories
{
    public class TeamRepository : IRepository<TeamEntity>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public TeamEntity Create(string name)
        {
            TeamEntity tm = new TeamEntity();

            tm.Name = name;
            tm.TeamUsers = new List<UserEntity>();
            using (DBConnect db = new DBConnect())
            {
                db.team.Add(tm);
                db.SaveChanges();
                //return true;
            }
            return tm;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            using (DBConnect db = new DBConnect())
            {
                var g = db.team.Where(x => x.Id == id).FirstOrDefault();

                if (g is TeamEntity)
                    db.Remove(g);
            }

            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TeamEntity> GetAll()
        {
            List<TeamEntity> t = new List<TeamEntity>();
            using(DBConnect db = new DBConnect())
            {
                t = db.team.AsQueryable().ToList();
            }
            return t;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TeamEntity GetOne(int id)
        {
            TeamEntity m = new TeamEntity();
            using (DBConnect db = new DBConnect())
            {
                m = db.team.Include(t => t.TeamUsers).Where(p => p.Id == id).FirstOrDefault();

            }
                return m;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(TeamEntity entity)
        {
            using(DBConnect db = new DBConnect())
            {
                db.team.Update(entity);
            }
                return true;
        }
    }
}
