using System.Collections.Generic;

namespace DashBoardAPI.ModelsAPI
{
    public class UserAPI
    {
        public int Id { get; set; }
        public string Pseudo { get; set; }

        public string Email { get; set; }

        public string PassWord { get; set; }
        public string Salt { get; set; }

        public ICollection<BoardAPI> Boards { get; set; }
        //public ICollection<int> Boards { get; set; }

        public ICollection<TeamAPI> Teams { get; set; }
        //public IEnumerable<int> Teams { get; set; }
    }
}
