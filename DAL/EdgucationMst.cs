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
    
    public partial class EdgucationMst
    {
        public int Id { get; set; }
        public Nullable<int> Sid { get; set; }
        public string CollageName { get; set; }
        public string Enrollno { get; set; }
        public string Semester { get; set; }
        public string Edgucation { get; set; }
        public string Branch { get; set; }
        public string Passyear { get; set; }
        public Nullable<double> CPI { get; set; }
        public Nullable<double> CGPA { get; set; }
        public string Skill { get; set; }
        public string ExtraSkill { get; set; }
        public string Resume { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
    }
}
