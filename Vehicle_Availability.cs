//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Team5Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehicle_Availability
    {
        public string Vehicle_id { get; set; }
        public string Branch_id { get; set; }
        public System.DateTime As_On_Date { get; set; }
    
        public virtual Branch_Admin Branch_Admin { get; set; }
        public virtual Vehicle_details Vehicle_details { get; set; }
    }
}
