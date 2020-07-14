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
    using System.ComponentModel.DataAnnotations;    
    public partial class Complain
    {
        public int ComplainID { get; set; }

        [Required(ErrorMessage = "Enter user name")]
        [Display(Name = "Enter Username :")]
        [StringLength(maximumLength: 20, MinimumLength = 10, ErrorMessage = "Username length must be Max 7 & Min 3")]
        public string Name { get; set; }

          [Required(ErrorMessage = "Please Enter the Discription")]
          [Display(Name = "Discription :")]
        public string Discription { get; set; }

         [Required(ErrorMessage = "This Email is required")]
        [Display(Name = "Email :")]

        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
          
        public string Emain { get; set; }
        public Nullable<int> pro_fk_Student { get; set; }
        public Nullable<int> pro_fk_Alumni { get; set; }


        [Required(ErrorMessage = "Upload Profile Image")]
        [Display(Name = "Profile Image : ")]
        public string com { get; set; }
            public virtual student student { get; set; }
       
        public virtual tbl_Alumni tbl_Alumni { get; set; }
    }
}
