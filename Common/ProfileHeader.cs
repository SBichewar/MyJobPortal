using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ProfileHeader
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public string CityName { get; set; }
        public string EmailId { get; set; }
        public int? AnualSaleryInLakh { get; set; }
        public int? AnualSaleryInThousent { get; set; }
        public int? MobileNo { get; set; }
    }
}
