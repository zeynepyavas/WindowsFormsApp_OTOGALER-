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
    
    public partial class Müsteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Müsteri()
        {
            this.Satis = new HashSet<Satis>();
        }
    
        public int müsteri_id { get; set; }
        public string müsteri_adsoy { get; set; }
        public string müsteri_mail { get; set; }
        public string müsteri_tc { get; set; }
        public string müsteri_tel { get; set; }
        public string müsteri_adres { get; set; }
        public Nullable<System.DateTime> müsteri_dogumtar { get; set; }
        public string resim { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }
    }
}
