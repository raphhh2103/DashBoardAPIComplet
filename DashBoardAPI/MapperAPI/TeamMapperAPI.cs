using BLL.Models;
using DashBoardAPI.ModelsAPI;
using System.Linq;

namespace DashBoardAPI.MapperAPI
{
    public static class TeamMapperAPI
    {
        public static TeamAPI ToAPI(this  TeamBLL modelBll)
        {
            return new TeamAPI()
            {
                Name = modelBll.Name,
                Id = modelBll.Id,
                TeamUsers = modelBll.TeamUsers
            };
        }

        public static TeamBLL ToBll(this TeamAPI modelApi)
        {
            return new TeamBLL()
            {
                Name = modelApi.Name,
                Id = modelApi.Id,
                TeamUsers = modelApi.TeamUsers
            };
        }
    }
}
