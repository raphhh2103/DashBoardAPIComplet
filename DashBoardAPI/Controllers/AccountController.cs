using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JwtBehavior.Auth;
using DashBoardAPI.Services;
using DashBoardAPI.ModelsAPI;
using BLL.MapperBLL;
using DashBoardAPI.MapperAPI;
using System.Text;

namespace DashBoardAPI.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly JwtSettings _jwtSetting;
        private readonly AccountServices _accountService;


        public AccountController(JwtSettings jwtSettings, AccountServices accountServices)
        {
            this._jwtSetting = jwtSettings;
            this._accountService = accountServices;
        }

        public IActionResult GetAuth(UserLogins userLogins)
        {
            //if (_accountService.VerifyUser(userLogins.ToUser()) == "email ou pseudo incorrect")
            //return BadRequest("email ou pseudo incorrect");
            //if(_accountService.VerifyUser(userLogin))
            //return Ok( _accountService.VerifyUser(userLogins.ToUser()));
            UserAPI user = new UserAPI();
            string str = "";
            byte[] bt = Crypto.GenerateSalt();


            user = _accountService.VerifyUser(userLogins.ToUser()).ToApi();
            if (user != null)
            str = Crypto.AshPassword(Encoding.ASCII.GetBytes(user.Salt), userLogins.Password);
                return Ok();




            if (str == user.PassWord)
                return Ok();

            else
                return BadRequest("error password");
                /*
             
             - verifier si les mdp sont les meme une fois acher avec la meme clef de salage 
             -
             
             */



            return Ok();

        }


    }

}
