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
            {
                str = Crypto.AshPassword(Encoding.ASCII.GetBytes(user.Salt), userLogins.Password);
                return Ok();


            }

            if (str == user.PassWord)
                return Ok();

            else
            {

            }
                return BadRequest("error password");
            /*
         - checker si l'utilisateur existe selon email ou pseudo 
            {
            - verfier le mdp avec la clef de salage de l'utilisateur recuperer ! 
            }
         - verifier si les mdp sont les meme une fois acher avec la meme clef de salage 
            {
                -  checker la ou c'est le plus simple pour eviter de faire traverser le mdp en clair dans toutes l'app x)
            }
         - generer le token pour l'utilisateur 
         - bloquer l'acces a tout ce qui existe si pas de token !!!! 
         - deplacer la connection string pour secure le machin , 
         - attaquer le front end ? en blazor
         */



            //return Ok();

        }


    }

}
