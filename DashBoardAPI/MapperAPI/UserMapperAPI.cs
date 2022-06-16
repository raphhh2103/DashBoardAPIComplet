using BLL.Models;
using DashBoardAPI.ModelsAPI;
using System.Linq;

namespace DashBoardAPI.MapperAPI
{
    public  static class UserMapperAPI
    {
        public static UserAPI ToApi(this UserBLL model )
        {
            return new UserAPI() {
                Id = model.Id,
                Pseudo = model.Pseudo,
                PassWord = model.PassWord,
                Email = model.Email,
                Boards = model.Boards,
                Teams = model.Teams,
                //foireux ! faire a la demande
                //Teams = model.Teams.Select(t=>t.ToApi())
            };

        }

    }
}
