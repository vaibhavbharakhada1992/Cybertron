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
            tb_users users = null;
            bool retval = false;
            try
            {
                using (kishmishEntities1 db = new kishmishEntities1())
                {
                    users = db.tb_users.Where(m => m.email == emailId).FirstOrDefault();
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
                using (kishmishEntities1 db = new kishmishEntities1())
                {
                    tb_users users = db.tb_users.Where(m => m.email == userName).FirstOrDefault();
                    if (users != null)
                    {
                        if (users.password == password)
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