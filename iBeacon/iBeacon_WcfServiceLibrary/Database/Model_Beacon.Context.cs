﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iBeacon_WcfServiceLibrary.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BeaconEntities : DbContext
    {
        public BeaconEntities()
            : base("name=BeaconEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BEACON_DEVICES> BEACON_DEVICES { get; set; }
        public virtual DbSet<ITEMS_ADVERTISEMENT> ITEMS_ADVERTISEMENT { get; set; }
        public virtual DbSet<MALL> MALLs { get; set; }
        public virtual DbSet<STORE> STOREs { get; set; }
    }
}
