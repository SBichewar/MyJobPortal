using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Common
{
    public class Education
    {
        public int EdgucationId { get; set; }
        public Nullable<int> UserId { get; set; }
        [Required]
        public Nullable<int> EducationType { get; set; }
        [Required]
        public string EducationTypeName { get; set; }
        [Required]
        public Nullable<int> StartMonth { get; set; }
        [Required]
        public Nullable<int> StartYear { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string CollageName { get; set; }
        [Required]
        public Nullable<int> QualificationId { get; set; }
        [Required]
        public string QualificationName { get; set; }
        [Required]
        public Nullable<int> SkillSetId { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        [Required]
        public Nullable<int> CityId { get; set; }
        [Required]
        public Nullable<int> PassingMonth { get; set; }
        [Required]
        public Nullable<int> PassingYear { get; set; }
        [Required]
        public Nullable<int> LocationDisrictId { get; set; }
    }
}
