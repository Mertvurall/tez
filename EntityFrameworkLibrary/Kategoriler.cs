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
    
    public partial class Kategoriler
    {
        public int KategoriID { get; set; }
        public Nullable<int> KatUstID { get; set; }
        public string KategoriAdi { get; set; }
        public string KategoriAciklama { get; set; }
        public string KategoriResimUrl { get; set; }
        public Nullable<bool> KatPopuler { get; set; }
    }
}
