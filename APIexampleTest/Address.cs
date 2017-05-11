using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIexampleTest
{
    public class Address
    {
        public Extension Extension { get; set; }
        public Id Id { get; set; }
        public object __type { get; set; }
        public bool IsNew { get; set; }
        public object Tag { get; set; }
        public AddressLine AddressLine1 { get; set; }
        public AddressLine AddressLine2 { get; set; }
        public AddressLine AddressLine3 { get; set; }
        public object City { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public object PostCode { get; set; }
        public object SubRegion { get; set; }
    }

}
