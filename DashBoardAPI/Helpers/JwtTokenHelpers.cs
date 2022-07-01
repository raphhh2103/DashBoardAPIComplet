using DashBoardAPI.ModelsAPI;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DashBoardAPI.Helpers
{
    public   class JwtTokenHelpers
    {
        private IConfiguration _configuration;
        public JwtTokenHelpers(IConfiguration config)
        {
            _configuration = config;
        }

        /*
         deploiement -> https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/?view=aspnetcore-6.0
         
         
         */

        public string Create(UserTokens model)
        {
            //1- recuperer la clé pour signer le token 
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._configuration["jwt:key"]));
            //2- le credential pour la validation de la signature 
            SigningCredentials credentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
            //3-creer le token
            JwtSecurityToken Token = new JwtSecurityToken(
                issuer: _configuration["jwt:issuer"],
                audience: _configuration["jwt:audience"],
                claims: GetClaims(model),
                notBefore: new DateTimeOffset(DateTime.UtcNow).DateTime,
                signingCredentials:credentials
                );
            model.Token = new JwtSecurityTokenHandler().WriteToken(Token);
            return "";
        
        }

        private static IEnumerable<Claim> GetClaims( /*this*/ UserTokens userAccounts)
        {
            IEnumerable<Claim> claims = new Claim[]
            {
                new Claim("Id",userAccounts.Id.ToString(),ClaimValueTypes.Integer64),
                new Claim("Pseudo",userAccounts.Pseudo),
                new Claim("Owner",userAccounts.IsOwner.ToString(), ClaimValueTypes.Boolean),
                new Claim("Email",userAccounts.Email),
                new Claim(ClaimTypes.Expiration,DateTime.UtcNow.AddDays(1).ToString(),ClaimValueTypes.DateTime),
            };
            return claims;
        }
    }
}

