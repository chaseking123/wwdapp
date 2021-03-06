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
    
    public partial class Vendor
    {
        public Vendor()
        {
            this.AcquisitionEvents = new HashSet<AcquisitionEvent>();
            this.VendorContacts = new HashSet<VendorContact>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> ContactInformationID { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<AcquisitionEvent> AcquisitionEvents { get; set; }
        public virtual ContactInformation ContactInformation { get; set; }
        public virtual VendorStatu VendorStatu { get; set; }
        public virtual ICollection<VendorContact> VendorContacts { get; set; }
    }
}
