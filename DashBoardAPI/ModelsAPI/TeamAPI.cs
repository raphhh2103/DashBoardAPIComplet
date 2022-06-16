using System.Collections.Generic;

namespace DashBoardAPI.ModelsAPI
{
    public class TeamAPI
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public IEnumerable<int> TeamUsers { get; set; }// recuperer l'id ! 

        //public IEnumerable<UserAPI> TeamUsers { get; set; }
      



    }
}