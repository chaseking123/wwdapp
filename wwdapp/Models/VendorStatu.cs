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
    
    public partial class VendorStatu
    {
        public VendorStatu()
        {
            this.Vendors = new HashSet<Vendor>();
        }
    
        public int Id { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
