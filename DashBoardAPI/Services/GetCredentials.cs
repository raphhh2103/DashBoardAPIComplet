using JwtBehavior.Auth;
using BLL.MapperBLL;
using DashBoardAPI.ModelsAPI;

namespace DashBoardAPI.Services
{
    public class GetCredentials
    {

        private readonly AccountServices _accountServices;
        public GetCredentials( AccountServices accountServices)
        {
            this._accountServices = accountServices;
        }


        public Account GetOwnerCredential(string credentialToVerify)
        {
            Account ownerCredential = _accountServices.GetOwnerCredentials(credentialToVerify).ToAccount();

            return ownerCredential;
        }




    }
}
