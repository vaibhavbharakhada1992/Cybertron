using KishMish.Data.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KishMish.Data.BusinessAccessLayer
{
    public static class BAUsers
    {
        public static bool BA_AuthenticateLoginDetails(string username,string password)
        {
            bool ret=false;
            ret = DAUsers.DA_AuthenticateLoginDetails(username,password);
            return ret;
        }
            
    }
}