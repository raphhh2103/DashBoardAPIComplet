using System.Collections.Generic;

namespace DashBoardAPI.ModelsAPI
{
    public class ProjectAPI
    {
        public int Id { get; set; }

        public string NameProject { get; set; }

        public IEnumerable<int> TeamUsers { get; set; }

    }
}
