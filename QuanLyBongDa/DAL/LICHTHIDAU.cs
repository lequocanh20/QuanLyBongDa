//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBongDa.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class LICHTHIDAU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LICHTHIDAU()
        {
            this.KETQUATHIDAUs = new HashSet<KETQUATHIDAU>();
        }
    
        public string MaTD { get; set; }
        public string DoiChuNha { get; set; }
        public string DoiKhach { get; set; }
        public Nullable<System.DateTime> NgayThiDau { get; set; }
        public Nullable<System.TimeSpan> GioThiDau { get; set; }
        public string SanThiDau { get; set; }
        public string MaVD { get; set; }
    
        public virtual DOIBONG DOIBONG { get; set; }
        public virtual DOIBONG DOIBONG1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KETQUATHIDAU> KETQUATHIDAUs { get; set; }
        public virtual VONGDAU VONGDAU { get; set; }
    }
}
