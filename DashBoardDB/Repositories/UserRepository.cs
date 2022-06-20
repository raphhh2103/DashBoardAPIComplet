using DashBoardDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Repositories
{
    public class UserRepository : IRepository<UserEntity>
    {
        /// <summary>
        /// creation d'un user  
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="pseudo"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool Create(UserEntity entity, IEnumerable<int> teamIds)
        {

           //  TeamRepository tr = new TeamRepository() ;
           //TeamEntity tm =  tr.Create("default");
           // tm.TeamUsers = new List<UserEntity>() { r };
           // tr.Update(tm);
           // r.Teams.ToList<TeamEntity>().Add(tm);
            using (DBConnect db = new DBConnect())
            {
                entity.Teams = teamIds.Select(id => db.team.First(t => t.Id == id)).ToList();
                db.User.Add(entity);
                db.SaveChanges();
            }
            BoardRepository br = new BoardRepository();
            BoardEntity be =  br.Create("default", entity);
            return true;

        }
        /// <summary>
        /// a modifier pour ne pas supprimer completement l'utilisateur ?
        /// pour le moment supprime un utilisateur ! 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            using (DBConnect db = new DBConnect())
            {
                var g = db.User.Where(x => x.Id == id).FirstOrDefault();

                if (g is UserEntity)
                    db.Remove(g);
            }

            return true;
        }
        /// <summary>
        /// recupere tout les users 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserEntity> GetAll()
        {
            List<UserEntity> r = new List<UserEntity>();
            using (DBConnect db = new DBConnect())
            {
                r = db.User.AsQueryable().ToList();
            }
            return r;
        }
        /// <summary>
        /// recupere un user selon un Id entrée en parametre 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserEntity GetOne(int id)
        {
            UserEntity t = new UserEntity();
            using (DBConnect db = new DBConnect())
            {
                t = db.User.Where(a => a.Id == id).FirstOrDefault();
                return t;
            }
        }
        /// <summary>
        /// recherche les différencces entre le user envoyer en parametre  et le user en db avec le meme ID
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(UserEntity entity)
        {
            using (DBConnect db = new DBConnect())
            {

                db.User.Update(entity);

                    return true;
                //}
            }
            
        }
    }
}
