using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCountry
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string IsoCode2 { get; set; }
        public string IsoCode3 { get; set; }
        public string AddressFormat { get; set; }
        public bool PostcodeRequired { get; set; }
        public bool? Status { get; set; }
    }
}
