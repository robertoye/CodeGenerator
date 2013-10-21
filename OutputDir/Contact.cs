    
/*
 * Created by zhye at 2013-10-21 17:28:51; 
 *
 *
 *
 *
 *
 * Copyright:Team
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Contact
    {
        public int ContactID { get ; set ; }
        public bool NameStyle { get ; set ; }
        public string Title { get ; set ; }
        public string FirstName { get ; set ; }
        public string MiddleName { get ; set ; }
        public string LastName { get ; set ; }
        public string Suffix { get ; set ; }
        public string EmailAddress { get ; set ; }
        public int EmailPromotion { get ; set ; }
        public string Phone { get ; set ; }
        public string PasswordHash { get ; set ; }
        public string PasswordSalt { get ; set ; }
        public string AdditionalContactInfo { get ; set ; }
        public string rowguid { get ; set ; }
        public string ModifiedDate { get ; set ; }
    }
}    