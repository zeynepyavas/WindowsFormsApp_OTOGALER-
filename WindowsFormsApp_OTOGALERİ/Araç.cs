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
    
    public partial class Araç
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Araç()
        {
            this.Satis = new HashSet<Satis>();
        }
    
        public int arac_id { get; set; }
        public Nullable<int> arac_fiyat { get; set; }
        public Nullable<int> arac_adet { get; set; }
        public string arac_marka { get; set; }
        public string arac_model { get; set; }
        public Nullable<int> arac_yıl { get; set; }
        public string arac_yakıt { get; set; }
        public string arac_vites { get; set; }
        public string arac_renk { get; set; }
        public Nullable<int> sube_id { get; set; }
        public string arac_durum { get; set; }
    
        public virtual Sube Sube { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }
    }
}
