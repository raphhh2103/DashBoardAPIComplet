using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JwtBehavior.Auth;
using DashBoardAPI.Services;
using DashBoardAPI.ModelsAPI;
using jwt = JwtBehavior.JwtHelpers;
using BLL.MapperBLL;
using DashBoardAPI.MapperAPI;
using System.Text;

namespace DashBoardAPI.Controllers
{
    [ApiController]

    [Route("index")]
    public class AccountController : ControllerBase
    {
        private readonly JwtSettings _jwtSetting;
        private readonly AccountServices _accountService;
        GetCredentials getCredentials;


        public AccountController(JwtSettings jwtSettings, AccountServices accountServices)
        {
            this._jwtSetting = jwtSettings;
            this._accountService = accountServices;
            this.getCredentials = new GetCredentials(_accountService);
        }

        [HttpPost]
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
                str = userLogins.Password;
                userLogins.Password = Crypto.AshPassword(Crypto.GenerateSalt(), userLogins.Password);
                userLogins.Password = Crypto.AshPassword(Encoding.ASCII.GetBytes(user.Salt), str);


                if (userLogins.Password == user.PassWord)
                {
                    UserTokens token = new UserTokens();
                    Account accountCredential = getCredentials.GetOwnerCredential(userLogins.Email);

                    token = jwt.JwtHelpers.GenTokenkey(new UserTokens()
                    {
                        Id = (int)accountCredential.Id,
                        Pseudo = accountCredential.Pseudo,
                        Email = accountCredential.Email,
                        IsOwner = false
                    },_jwtSetting);

                    return Ok();
                }
                else
                {
                    return BadRequest("mot de passe incorrect ");
                }
            }
            else
            {
                return BadRequest("une erreur est survenue ! ");
            }
            /*
         //- checker si l'utilisateur existe selon email ou pseudo 
            {
          //  - verfier le mdp avec la clef de salage de l'utilisateur recuperer ! 
            }
         //- verifier si les mdp sont les meme une fois acher avec la meme clef de salage 
            {
            //    -  checker la ou c'est le plus simple pour eviter de faire traverser le mdp en clair dans toutes l'app x)
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
