using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Common
{
    public class Employement
    {
        public int EmployementId { get; set; }
        [Required]
        public Nullable<bool> IscurrentCompany { get; set; }
        public Nullable<int> SkillSetId { get; set; }
        [Required]
        public string SkillSet { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public Nullable<int> LocationDisrictId { get; set; }
        [Required]
        public Nullable<int> StartMonth { get; set; }
        [Required]
        public Nullable<int> StartYear { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        [Required]
        public  string NoticePeriod { get; set; }
        public Nullable<bool> IsEnable { get; set; }
        [Required]
        public Nullable<int> EndMonth { get; set; }
        [Required]
        public Nullable<int> EndYear { get; set; }
        public Nullable<int> UearId { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public Nullable<int> AnualSaleryInLakh { get; set; }
        [Required]
        public Nullable<int> AnualSaleryInThousent { get; set; }
        [Required]
        public string SaleryIn { get; set; }
    }
}
