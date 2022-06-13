using System.Collections.Generic;

namespace DashBoardAPI.ModelsAPI
{
    public class TeamAPI
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<UserAPI> MyProperty { get; set; }



    }
}