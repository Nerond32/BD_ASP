//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD_Proj
{
    using System;
    using System.Collections.Generic;
    
    public partial class USERS
    {
        public int userId { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int roleId { get; set; }
        public int scoreId { get; set; }
    
        public virtual ROLES ROLES { get; set; }
        public virtual SCORES SCORES { get; set; }
    }
}
