//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMS_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BusinessPartner
    {
        public BusinessPartner()
        {
            this.NewProjects = new HashSet<NewProject>();
        }
    
        public int Id { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string OwnerName { get; set; }
        public string ContactNo { get; set; }
        public string Emailid { get; set; }
    
        public virtual ICollection<NewProject> NewProjects { get; set; }
    }
}
