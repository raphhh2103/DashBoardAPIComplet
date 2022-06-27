using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Entities
{
    public class BoardEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public UserEntity UserOwner { get; set; }
        public int UserOwnerId { get; set; }

        //public int Contents { get; set; }
<<<<<<< HEAD
        public ICollection<ContentEntity> Contents { get; set; }
=======
        public IEnumerable<ContentEntity> Contents { get; set; }


>>>>>>> 9b4b8d11ee1ac5294b585e0a2a82d2e118d303b0
    }
}
