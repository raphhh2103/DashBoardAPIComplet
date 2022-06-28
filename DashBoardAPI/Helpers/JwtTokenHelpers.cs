using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace DashBoardAPI.Helpers
{
    public class JwtTokenHelpers
    {
        private IConfiguration _configuration;

        /*
         deploiement -> https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/?view=aspnetcore-6.0
         
         
         */

        public JwtTokenHelpers(IConfiguration config)
        {
            _configuration = config;
        }
        public string Create(string login)
        {
            //1- recuperer la clé pour signer le token 
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._configuration["jwt:key"]));
            //2- le credential pour la validation de la signature 
            SigningCredentials credentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
            //3-creer le token
            return "";
        
        
        }
    }
}
