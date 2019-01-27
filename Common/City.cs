using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public Nullable<int> DistId { get; set; }
        public Nullable<int> StateId { get; set; }
        public Nullable<int> CountryId { get; set; }
    }
}
