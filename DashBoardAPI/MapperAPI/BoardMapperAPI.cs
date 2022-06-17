using BLL.Models;
using DashBoardAPI.ModelsAPI;

namespace DashBoardAPI.MapperAPI
{
    public static class BoardMapperAPI
    {
        public static BoardAPI ToApi(this BoardBLL model)
        {
            return new BoardAPI()
            {
                Id = model.Id,
                Contents = model.Contents,
                Title = model.Title,
                UserOwner = model.UserOwner.ToApi(),
                
            };
        }


    }
}
