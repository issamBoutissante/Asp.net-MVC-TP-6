//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Asp.net_MVC_TP_6.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pilote
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pilote()
        {
            this.Vols = new HashSet<Vol>();
        }
    
        public int NumPil { get; set; }
        public string NomPil { get; set; }
        public string PrenomPil { get; set; }
        public string Adresse { get; set; }
        public decimal Salaire { get; set; }
        public Nullable<decimal> Prime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vol> Vols { get; set; }
    }
}
