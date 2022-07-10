using BLL.Models;
using DashBoardAPI.ModelsAPI;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Text;

namespace DashBoardAPI.MapperAPI
{
    public  static class UserMapperAPI
    {
        public static UserAPI ToApi(this UserBLL model )
        {
            return new UserAPI() {
                Id = model.Id,
                Pseudo = model.Pseudo,
                PassWord = Convert.ToBase64String(model.PassWord),
                Salt = Convert.ToBase64String(model.Salt),
                Email = model.Email,
                Boards = (ICollection<BoardAPI>)model.Boards,
                Teams = (ICollection<TeamAPI>)model.Teams,
                //foireux ! faire a la demande
                //Teams = model.Teams.Select(t=>t.ToApi())
            };

        }

        public static UserBLL ToBll(this UserAPI model)
        {
            return new UserBLL()
            {
                Id = model.Id,
                Pseudo = model.Pseudo,
                PassWord = Encoding.ASCII.GetBytes( model.PassWord),
                Salt = Encoding.ASCII.GetBytes(model.Salt), 
                Email = model.Email,
                Boards = (ICollection<BoardBLL>)model.Boards,
                Teams = (ICollection<TeamBLL>)model.Teams,
                //foireux ! faire a la demande
                //Teams = model.Teams.Select(t=>t.ToApi())
            };


           

        }
        //public static object ToView(this UserAPI model)
        //{
        //    return new object()
        //    {

        //    };
        //}
    }
}
