//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplikacija.BP
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProvjeraZadatak
    {
        public int sifraProvjeraZadatak { get; set; }
        public int sifraProvjere { get; set; }
        public int sifraZadatka { get; set; }
        public double bodovi { get; set; }
        public double negativno { get; set; }
        public double odgovor { get; set; }
        public double dobiveno { get; set; }
    
        public virtual Provjera Provjera { get; set; }
        public virtual Zadatak Zadatak { get; set; }
    }
}