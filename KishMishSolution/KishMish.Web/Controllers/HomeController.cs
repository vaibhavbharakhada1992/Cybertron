using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.SessionState;
using KishMish.Web.Filters;

namespace KishMish.Web.Controllers
{
    public class HomeController : Controller
    {        
        [Authorize, NoCache]
        //[CacheControl(HttpCacheability.NoCache)]
        // GET: Home

        public ActionResult Home()
        {
            return View();
        }
        
        [Authorize]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            //Session["userID"] = null;
            return RedirectToActionPermanent("Login", "Login");
        }
    }
}