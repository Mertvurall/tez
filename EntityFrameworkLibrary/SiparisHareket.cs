//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class SiparisHareket
    {
        public int SipHarID { get; set; }
        public Nullable<int> siparisKartID { get; set; }
        public Nullable<System.DateTime> SipHarTarih { get; set; }
        public Nullable<int> SipHarMiktar { get; set; }
        public Nullable<decimal> SipHarFiyat { get; set; }
        public Nullable<decimal> SipHarTutar { get; set; }
        public Nullable<int> SipHarUrunID { get; set; }
        public string SipHarUrunAdi { get; set; }
    }
}
