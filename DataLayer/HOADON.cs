//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOADON
    {
        public int IDhoadon { get; set; }

        public Double Thanhtien { get; set; }
        public int IDkhachhang { get; set; }
        public int IDphong { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual PHONG PHONG { get; set; }
    }
}
