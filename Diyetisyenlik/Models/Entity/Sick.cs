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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sick()
        {
            this.SickDiet = new HashSet<SickDiet>();
            this.SickDisease = new HashSet<SickDisease>();
        }
    
        public int SickId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Ä_dentityNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SickDiet> SickDiet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SickDisease> SickDisease { get; set; }
    }
}