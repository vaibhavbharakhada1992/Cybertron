using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KishMish.Data;

namespace KishMish.Data.DataAccessLayer
{
    public static class DAUsers
    {

        //public static void MethodName()
        //{
            
        //    try
        //    {
        //        using (kishmishEntities1 db = new kishmishEntities1())
        //        {
                    
        //        }
        //    }
        //    catch
        //    {

        //    }
        //    finally
        //    {

        //    }
            
        //}

        public static bool DA_CheckUserExistance(string emailId)
        {
            User users = null;
            bool retval = false;
            try
            {
                using (KishMishEntities db = new KishMishEntities())
                {
                    users = db.Users.Where(m => m.EmailId == emailId).FirstOrDefault();
                    if (users != null)
                    {
                        retval = true;
                    }
                }
            }
            catch (Exception ex)
            {
                retval = false;
            }
            finally
            {

            }

            return retval;
        }


        public static bool DA_AuthenticateLoginDetails(string userName, string password)
        {
            bool retval = false;
            try
            {
                using (KishMishEntities db = new KishMishEntities())
                {
                    User users = db.Users.Where(m => m.EmailId == userName).FirstOrDefault();
                    if (users != null)
                    {
                        if (users.Password == password)
                        {
                            retval = true;
                        }
                        else { retval = false; }
                    }
                }               
            }
            catch (Exception ex)
            {
                retval = false;
            }
            finally
            {                
            }
            return retval;            
        }
    }
}