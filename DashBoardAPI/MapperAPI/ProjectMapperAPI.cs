using BLL.Models;
using DashBoardAPI.ModelsAPI;

namespace DashBoardAPI.MapperAPI
{
    public static class ProjectMapperAPI
    {

        public static ProjectAPI ToApi(this ProjectBLL model)
        {
            return new ProjectAPI()
            {
                Id = model.Id,
                NameProject = model.NameProject,
                TeamUsers = model.TeamUsers,
            };
        }

    }
}
