//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diyetisyenlik.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sick
    {
        public int SickId { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public Nullable<int> DiseaseId { get; set; }
        public Nullable<int> DietId { get; set; }
        public string FirstName { get; set; }
    
        public virtual Diet Diet { get; set; }
        public virtual Disease Disease { get; set; }
    }
}
