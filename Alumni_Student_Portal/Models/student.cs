//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alumni_Student_Portal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class student
    {
        public student()
        {
            this.Complains = new HashSet<Complain>();
            this.CVs = new HashSet<CV>();
            this.goings = new HashSet<going>();
        }
    
        public int stu_id { get; set; }
        public string stu_name { get; set; }
        public string stu_rollnum { get; set; }
        public string stu_password { get; set; }
    
        public virtual ICollection<Complain> Complains { get; set; }
        public virtual ICollection<CV> CVs { get; set; }
        public virtual ICollection<going> goings { get; set; }
    }
}
