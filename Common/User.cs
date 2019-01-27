using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string GenderId { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> ProfilePicId { get; set; }
        public string ImagePath { get; set; }
        public Nullable<int> ResumeId { get; set; }
        public Nullable<bool> IsEnable { get; set; }
        public Nullable<int> UserType { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public Nullable<int> CityId { get; set; }
        public string CityName { get; set; }
    }

}
