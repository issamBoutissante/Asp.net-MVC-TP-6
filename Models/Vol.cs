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
    
    public partial class Vol
    {
        public int NumVol { get; set; }
        public int NumPil { get; set; }
        public int NumAv { get; set; }
        public System.DateTime Date_Vol { get; set; }
        public int Heure_dep { get; set; }
        public int Heure_arr { get; set; }
        public string Ville_dep { get; set; }
        public string Ville_arr { get; set; }
    
        public virtual Avion Avion { get; set; }
        public virtual Pilote Pilote { get; set; }
    }
}
