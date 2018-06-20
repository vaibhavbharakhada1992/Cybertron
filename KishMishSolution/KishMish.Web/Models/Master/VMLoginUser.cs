using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KishMish.Web.Models.Master
{
    public class VMLoginUser
    {
        
        private string userName;
        private string password;
        private bool isRemember;

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

        public bool IsRemember
        {
            get
            {
                return isRemember;
            }

            set
            {
                isRemember = value;
            }
        }
    }
}