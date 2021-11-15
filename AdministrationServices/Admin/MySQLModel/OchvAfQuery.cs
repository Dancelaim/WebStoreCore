using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvAfQuery
    {
        public int QueryId { get; set; }
        public string Path { get; set; }
        public string Params { get; set; }
        public int Popularity { get; set; }
    }
}
