﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoomReservationSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AzureConnection : DbContext
    {
        public AzureConnection()
            : base("name=AzureConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FLOOR> FLOOR { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Event_Type> Event_Type { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Event> Event { get; set; }
    }
}
