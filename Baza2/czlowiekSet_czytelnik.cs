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
    
    public partial class czlowiekSet_czytelnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public czlowiekSet_czytelnik()
        {
            this.wypozyczenieSet = new HashSet<wypozyczenieSet>();
        }
    
        public int IdC { get; set; }
        public int Id { get; set; }
        public Nullable<int> iloscksiazek { get; set; }
    
        public virtual czlowiekSet czlowiekSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wypozyczenieSet> wypozyczenieSet { get; set; }
    }
}
