using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KishMish.Data.Entities.MasterEntities
{
    public class BaseTraders
    {
        private string name;
        private string username;
        private string password;
        private string guid;
        private string firstname;
        private string lastname;
        private string phonenumber;
        private string email;
        private DateTime createOn;
        
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

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

        public string Guid
        {
            get
            {
                return guid;
            }

            set
            {
                guid = value;
            }
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public string Phonenumber
        {
            get
            {
                return phonenumber;
            }

            set
            {
                phonenumber = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime CreateOn
        {
            get
            {
                return createOn;
            }

            set
            {
                createOn = value;
            }
        }
    }
    
}