using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Entities
{
    public class UserEntity
    {
        //public int Id { get; set; }

        //public string Pseudo { get; set; }

        //public string Email { get; set; }

        //public string PssWd { get; set; }
        //// a deplacer ! 
        //public string Salt { get; set; }

        ////public int Boards { get; set; }
        ////a changer putain de merde ! 
        //public ICollection<BoardEntity> Boards { get; set; }
        ////public int Teams { get; set; }
        //public ICollection<TeamEntity> Teams { get; set; }

        public int Id { get; set; }
        public string Pseudo { get; set; }
        public string Email { get; set; }
        public byte[] Passwd { get; set; }
        public byte[] SaltKey { get; set; }

        public virtual ICollection<BoardEntity> Boards { get; set; }
        
        public virtual ICollection<TeamEntity> Teams { get; set; }

    }
}
