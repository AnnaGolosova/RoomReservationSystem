//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Equipment
    {
        public int Id { get; set; }
        public int IdRoom { get; set; }
        public int IdInventory { get; set; }
    
        public virtual Inventory Inventory { get; set; }
        public virtual Room Room { get; set; }
    }
}