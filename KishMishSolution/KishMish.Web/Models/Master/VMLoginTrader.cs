using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KishMish.Web.Models.Master
{
    public class VMLoginTrader
    {
        
        private string userName;
        private string password;
        [Required]
        [Display(Name ="User Name :")]
        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        [Required]
        [Display(Name = "Password :")]
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}