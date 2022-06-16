using BLL.Models;
using DashBoardAPI.ModelsAPI;
using System.Linq;

namespace DashBoardAPI.MapperAPI
{
    public static class TeamMapperAPI
    {
        public static TeamAPI ToAPI(this  TeamBLL model)
        {
            return new TeamAPI()
            {
                Name = model.Name,
                Id = model.Id,
                TeamUsers = model.TeamUsers
            };
        }

    }
}
