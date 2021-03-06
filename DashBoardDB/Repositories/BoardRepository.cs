using DashBoardDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Repositories
{
    public class BoardRepository /*: IRepository<BoardEntity>*/
    {
        public BoardEntity Create(string title, UserEntity user)
        {
            BoardEntity b = new BoardEntity();
            b.Title = title;
            //b.UserOwnerId = user.Id;

            //b.t
            using (DBConnect db = new DBConnect())
            {
                db.Board.Add(b);
                db.SaveChanges();

            }
            return b;
        }

        public bool Delete(int id)
        {
            using (DBConnect db = new DBConnect())
            {

                BoardEntity g = db.Board.Where(d => d.Id == id).FirstOrDefault();
                if (g is BoardEntity)
                    db.Remove(g);

            }
            return true;
        }

        public IEnumerable<BoardEntity> GetAll()
        {
            List<BoardEntity> c = new List<BoardEntity>();
            using (DBConnect db = new DBConnect())
            {
                c = db.Board.AsQueryable().ToList();
            }

            return c;
        }

        public BoardEntity GetOne(int id)
        {

            BoardEntity b = new BoardEntity();
            using (DBConnect db = new DBConnect())
            {
                b = db.Board.Where(d => d.Id == id).FirstOrDefault();

            }
            return b;
        }



        public bool Update(BoardEntity entity)
        {
            using (DBConnect db = new DBConnect())
            {
                db.Board.Update(entity);
            }
            return true;
        }
    }
}
