using BLL.Models;
using DashBoardAPI.ModelsAPI;

namespace DashBoardAPI.MapperAPI
{
    public static class ContentMapperAPI
    {
        public static ContentAPI ToApi(this ContentBLL model)
        {
            return new ContentAPI()
            {
                Id = model.Id,
                Text = model.Text,
                TitleBoard = model.TitleBoard.ToApi(),
            };
        }
        public static ContentBLL ToBll(this ContentAPI model)
        {
            return new ContentBLL()
            {
                Id = model.Id,
                Text = model.Text/*,
                TitleBoard = model.TitleBoard,*/
            };
        }
        

    }
}
