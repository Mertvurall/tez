﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ElektronikMagazaDBEntities : DbContext
    {
        public ElektronikMagazaDBEntities()
            : base("name=ElektronikMagazaDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<SiparisKart> SiparisKart { get; set; }
        public virtual DbSet<Bayiler> Bayiler { get; set; }
        public virtual DbSet<SiparisHareket> SiparisHareket { get; set; }
    }
}