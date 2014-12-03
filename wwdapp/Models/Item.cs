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
    
    public partial class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<int> AcquisitionEventID { get; set; }
        public Nullable<int> ItemStatusID { get; set; }
        public Nullable<int> ItemTypeID { get; set; }
        public Nullable<int> DeliveryMadeID { get; set; }
    
        public virtual AcquisitionEvent AcquisitionEvent { get; set; }
        public virtual DeliveryMade DeliveryMade { get; set; }
        public virtual ItemStatu ItemStatu { get; set; }
        public virtual ItemType ItemType { get; set; }
    }
}
