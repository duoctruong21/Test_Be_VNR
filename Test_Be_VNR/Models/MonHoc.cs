//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test_Be_VNR.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MonHoc
    {
        public int ID { get; set; }
        public string TenMonHoc { get; set; }
        public string MoTa { get; set; }
        public int KhoaHocID { get; set; }
    
        public virtual KhoaHoc KhoaHoc { get; set; }
    }
}