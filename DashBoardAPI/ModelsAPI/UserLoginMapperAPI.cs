using JwtBehavior.Auth;

namespace DashBoardAPI.ModelsAPI
{
    public static class UserLoginMapperAPI
    {
        public static UserAPI ToUser(this UserLogins login)
        {
           return new UserAPI() 
           { 
               Email = login.Email,
                PassWord = login.Password,
                Pseudo = login.pseudo
           };
            
            
        }


    }
}
