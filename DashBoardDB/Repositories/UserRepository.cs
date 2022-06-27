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
        public UserEntity Create(UserEntity entity/*, IEnumerable<TeamEntity> teams*/)
        {

            //  TeamRepository tr = new TeamRepository() ;
            //TeamEntity tm =  tr.Create("default");
            // tm.TeamUsers = new List<UserEntity>() { r };
            // tr.Update(tm);
            // r.Teams.ToList<TeamEntity>().Add(tm);
            using (DBConnect db = new DBConnect())
            {
                //entity.Teams = teams.Select(id => db.team.First(t => t.Id == id)).ToList();
                db.User.Add(entity);
                db.SaveChanges();
            }
            BoardRepository br = new BoardRepository();
            BoardEntity be = br.Create("default", entity);
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
            //List<TeamEntity> team = new List<TeamEntity>();
            //TeamRepository tr = new TeamRepository();

            using (DBConnect db = new DBConnect())
            {
                r = db.User.AsQueryable().ToList();
                //team = db.team.AsQueryable().ToList();
                //for (int i = 0; i < r.Count; i++)
                //{
                //    foreach (var item in team[i].TeamUsers)
                //    {
                //        if (r[i].Id == item.Id)
                //        {
                //            r[i].Teams = team;
                //        }
                //    }
                //}
            }
            return user;
        }
        /// <summary>
        /// recupere un user selon un Id entrée en parametre 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserEntity GetOne(int id)
        {
            UserEntity user = new UserEntity();
            //BoardRepository br = new BoardRepository();
            using (DBConnect db = new DBConnect())
            {

                user = db.User.Find(id);
                //t.Boards = (ICollection<BoardEntity>)db.Board.Find(t.Id);

                // t = db.User.Where(a => a.Id == id).FirstOrDefault();
                ///* t.Boards =*/
                // var test = db.Board.Select(r=>r.UserOwnerId).ToList()/*.where( q=>q.Id ==   )*/;

            }
            //if (t.Boards is not null)
            //{
                return user;
            //}
            //return null;
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
