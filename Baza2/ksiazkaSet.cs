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
    
    public partial class ksiazkaSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ksiazkaSet()
        {
            this.wypozyczenieSet = new HashSet<wypozyczenieSet>();
        }
    
        public int Id { get; set; }
        public string tytul { get; set; }
        public string autor { get; set; }
        public short wydanie { get; set; }
        public string wydawca { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wypozyczenieSet> wypozyczenieSet { get; set; }
    }
}