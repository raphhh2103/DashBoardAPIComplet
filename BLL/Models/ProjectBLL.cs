using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ProjectBLL
    {

        public int Id { get; set; }

        public string NameProject { get; set; }

        public IEnumerable<int> TeamUsers { get; set; }
        //public IEnumerable<UserBLL> TeamsUsers { get; set; }
    }
}
