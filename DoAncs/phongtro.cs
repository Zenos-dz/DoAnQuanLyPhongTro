//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Doancs
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhongTro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhongTro()
        {
            this.HoaDon = new HashSet<HoaDon>();
            this.HopDong = new HashSet<HopDong>();
        }
    
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public Nullable<double> DienTich { get; set; }
        public Nullable<int> GiaTienPhong { get; set; }
    
        public virtual CoSoVatChat CoSoVatChat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDong> HopDong { get; set; }
        public virtual SoDienNuoc SoDienNuoc { get; set; }
    }
}
