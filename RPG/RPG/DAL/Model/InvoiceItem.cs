//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPG.DAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceItem
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int MaterialId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public string Notes { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Material Material { get; set; }
    }
}
