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
    
    public partial class Satis
    {
        public int satis_id { get; set; }
        public Nullable<System.DateTime> satis_tarihi { get; set; }
        public Nullable<decimal> satis_fiyati { get; set; }
        public Nullable<int> müsteri_id { get; set; }
        public Nullable<int> arac_id { get; set; }
        public Nullable<int> personel_id { get; set; }
    
        public virtual Araç Araç { get; set; }
        public virtual Müsteri Müsteri { get; set; }
        public virtual Personel Personel { get; set; }
    }
}
