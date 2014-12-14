//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wwdapp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SupportEvent
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> TimeStart { get; set; }
        public Nullable<System.DateTime> TimeEnd { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> ProcedureID { get; set; }
        public string Description { get; set; }
        public Nullable<int> TicketID { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Procedure Procedure { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}