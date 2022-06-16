using System.Collections.Generic;

namespace DashBoardAPI.ModelsAPI
{
    public class BoardAPI
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public UserAPI UserOwner { get; set; }

        public IEnumerable<int> Contents { get; set; }
        //public IEnumerable<ContentAPI> Contents { get; set; }
    }
}