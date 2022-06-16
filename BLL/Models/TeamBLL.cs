using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class TeamBLL
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<int> TeamUsers { get; set; }
        //public IEnumerable<UserBLL> TeamUsers { get; set; }



    }
}
