//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp_OTOGALERİ
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personel()
        {
            this.Satis = new HashSet<Satis>();
        }
    
        public int personel_id { get; set; }
        public string personel_adsoy { get; set; }
        public Nullable<int> yas { get; set; }
        public string tc { get; set; }
        public string mail { get; set; }
        public Nullable<int> telefon { get; set; }
        public string adres { get; set; }
        public Nullable<int> sube_id { get; set; }
    
        public virtual Sube Sube { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }
    }
}
