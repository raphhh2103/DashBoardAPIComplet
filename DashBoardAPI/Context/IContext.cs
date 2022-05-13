using DashBoardDAL.Entities;
using DashBoardDAL.Repositories;

namespace DashBoardAPI.Context
{
    public interface IContext
    {

        public UserEntity User { get; set; }
        public TeamEntity Team { get; set; }

        public ProjectEntity Project { get; set; }
        public ContentEntity Content { get; set; }
        public BoardEntity Board { get; set; }

     




    }
}
