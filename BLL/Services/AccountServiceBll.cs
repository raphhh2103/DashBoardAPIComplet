using BLL.MapperBLL;
using BLL.Models;
using DashBoardDAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AccountServiceBll
    {
        private readonly AccountServicesDAL _accountServiceDAL;



        public UserBLL VerifyUser(UserBLL auth)
        {
            //user = new UserBLL();
            return _accountServiceDAL.VerifyUser(auth.ToEntity()).ToBLL();
        }

        public UserBLL GetOwnerCredentials(string credentialToVerify)
        {
            return _accountServiceDAL.GetOwnerCredentialsDAL(credentialToVerify).ToBLL();
        }
    }
}
