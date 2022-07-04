using DashBoardDAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Services
{
    public class AccountServicesDAL
    {

        //public string VerifyUser(UserEntity auth, out UserEntity user)
        //{

        //    try
        //    {
        //        using (DBConnect db = new DBConnect())
        //        {
        //            // SqlParameter customerEmail = new SqlParameter("@customerEmail", email);


        //            if (db.User.Find(auth.Email) != null || db.User.Find(auth.Pseudo) != null)
        //            {
        //                if (db.User.Find(auth.Passwd) != null)
        //                {
        //                    user = db.User.Find(auth.Email);
        //                    return "ok";
        //                }
        //                user = null;
        //                return "password incorrect";
        //            }
        //            user = null;
        //            return "email ou pseudo incorrect";


        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        public UserEntity VerifyUser(UserEntity auth)
        {
            UserEntity user = new UserEntity();
            try
            {
                using (DBConnect db = new DBConnect())
                {
                    // SqlParameter customerEmail = new SqlParameter("@customerEmail", email);


                    if (db.User.Find(auth.Email) != null || db.User.Find(auth.Pseudo) != null)
                    {
                        if (db.User.Find(auth.Passwd) != null)
                        {
                            user = db.User.Find(auth.Email);
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                    return user;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
