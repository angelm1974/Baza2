//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Baza2
{
    using System;
    using System.Collections.Generic;
    
    public partial class czlowiekSet
    {
        public int Id { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public short wiek { get; set; }
    
        public virtual czlowiekSet_bibliotekarz czlowiekSet_bibliotekarz { get; set; }
        public virtual czlowiekSet_czytelnik czlowiekSet_czytelnik { get; set; }
    }
}
