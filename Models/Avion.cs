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
    
    public partial class Avion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Avion()
        {
            this.Vols = new HashSet<Vol>();
        }
    
        public int NumAv { get; set; }
        public string NomAv { get; set; }
        public int Capacite { get; set; }
        public string Localisation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vol> Vols { get; set; }
    }
}
