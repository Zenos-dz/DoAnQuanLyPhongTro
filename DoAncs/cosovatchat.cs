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
    
    public partial class CoSoVatChat
    {
        public string MaPhong { get; set; }
        public Nullable<bool> DieuHoa { get; set; }
        public Nullable<bool> QuatDien { get; set; }
        public Nullable<bool> TuLanh { get; set; }
        public Nullable<bool> BinhNongLanh { get; set; }
    
        public virtual PhongTro PhongTro { get; set; }
    }
}
