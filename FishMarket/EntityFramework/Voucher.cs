//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Voucher
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string VoucherCode { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
