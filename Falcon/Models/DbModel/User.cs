//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Falcon.Models.DbModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string CNIC { get; set; }
        public Nullable<bool> IsInterestedInCSharp { get; set; }
        public Nullable<bool> IsInterestedInPHP { get; set; }
        public Nullable<bool> IsInterestedInJava { get; set; }
        public Nullable<int> CityID { get; set; }
        public string ImagePath { get; set; }
    
        public virtual City City { get; set; }
    }
}
