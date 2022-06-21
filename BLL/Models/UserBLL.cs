
using System.Collections.Generic;

namespace BLL.Models
{
    public class UserBLL
    {

        public int Id { get; set; }
        public string Pseudo { get; set; }

        public string Email { get; set; }

        public string PassWord { get; set; }
        //public byte[] Salt { get; set; }
        public string Salt { get; set; }

        //public int Boards { get; set; }
        public ICollection<BoardBLL> Boards { get; set; }

        public ICollection<TeamBLL> Teams { get; set; }
        // recuperer uniquement l'ID 
        //public IEnumerable<TeamBLL> Teams { get; set; }
    }
}