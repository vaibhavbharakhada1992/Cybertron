using KishMish.Data.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KishMish.Data.BusinessAccessLayer
{
    public static class BAUsers
    {

        public static bool BA_CheckUserExistance(string emailId)
        {
            bool ret = false;
            ret = DAUsers.DA_CheckUserExistance(emailId);
            return ret;
        }

        public static tb_users BA_AuthenticateLoginDetails(string emailId,string password)
        {
            tb_users user = DAUsers.DA_AuthenticateLoginDetails(emailId, password);
            return user;
        }
            
    }
}