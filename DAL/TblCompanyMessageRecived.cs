//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblCompanyMessageRecived
    {
        public int MessageId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<System.DateTime> MessageDate { get; set; }
        public string MessageDiscription { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> PostId { get; set; }
        public Nullable<bool> IsApplyed { get; set; }
    }
}
