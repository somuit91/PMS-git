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
    
    public partial class ProjectPicture
    {
        public int Id { get; set; }
        public string Picture { get; set; }
        public int VisitReportId { get; set; }
    
        public virtual VisitReport VisitReport { get; set; }
    }
}
