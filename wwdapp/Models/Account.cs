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
    
    public partial class Account
    {
        public Account()
        {
            this.AccountContacts = new HashSet<AccountContact>();
            this.DeliveryMades = new HashSet<DeliveryMade>();
            this.EmailAddresses = new HashSet<EmailAddress>();
            this.InternetDomains = new HashSet<InternetDomain>();
            this.Invoices = new HashSet<Invoice>();
            this.IPAddresses = new HashSet<IPAddress>();
            this.PaymentReceiveds = new HashSet<PaymentReceived>();
            this.Projects = new HashSet<Project>();
            this.Services = new HashSet<Service>();
            this.SoftwareInstallations = new HashSet<SoftwareInstallation>();
            this.SupportAgreements = new HashSet<SupportAgreement>();
            this.Tickets = new HashSet<Ticket>();
            this.VPNs = new HashSet<VPN>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> ContactInformationID { get; set; }
        public Nullable<int> AccountTypeID { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<AccountContact> AccountContacts { get; set; }
        public virtual AccountType AccountType { get; set; }
        public virtual ContactInformation ContactInformation { get; set; }
        public virtual ICollection<DeliveryMade> DeliveryMades { get; set; }
        public virtual ICollection<EmailAddress> EmailAddresses { get; set; }
        public virtual ICollection<InternetDomain> InternetDomains { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<IPAddress> IPAddresses { get; set; }
        public virtual ICollection<PaymentReceived> PaymentReceiveds { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<SoftwareInstallation> SoftwareInstallations { get; set; }
        public virtual ICollection<SupportAgreement> SupportAgreements { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<VPN> VPNs { get; set; }
    }
}