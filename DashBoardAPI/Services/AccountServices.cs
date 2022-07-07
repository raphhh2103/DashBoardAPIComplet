using BLL.Models;
using BLL.Services;
using DashBoardAPI.MapperAPI;
using DashBoardAPI.ModelsAPI;
using System;

namespace DashBoardAPI.Services
{
    public class AccountServices
    {
        private readonly AccountServiceBll _accountServiceBll;

        public AccountServices(AccountServiceBll accountService)
        {
            this._accountServiceBll = accountService;
        }
        public UserBLL VerifyUser(UserAPI auth)
        {
            return _accountServiceBll.VerifyUser(auth.ToBll());
        }

        internal UserAPI GetOwnerCredentials(string credentialToVerify)
        {
            return _accountServiceBll.GetOwnerCredentials(credentialToVerify).ToApi();
        }
    }
}
