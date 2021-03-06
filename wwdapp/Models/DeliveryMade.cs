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
    
    public partial class DeliveryMade
    {
        public DeliveryMade()
        {
            this.Invoices = new HashSet<Invoice>();
            this.Items = new HashSet<Item>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> DateOrdered { get; set; }
        public Nullable<System.DateTime> DateDelivered { get; set; }
        public Nullable<int> EmployeeOrderedID { get; set; }
        public Nullable<int> EmployeeDeliveredID { get; set; }
        public string Description { get; set; }
        public Nullable<int> AccountID { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
