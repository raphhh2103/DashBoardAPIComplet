using System.Collections.Generic;

namespace BLL.Models
{
    public class BoardBLL
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public UserBLL UserOwner { get; set; }

        public int Contents { get; set; }
        //public IEnumerable<ContentBLL> Contents { get; set; }
    }
}