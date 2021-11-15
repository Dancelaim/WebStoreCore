using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvSession
    {
        public string SessionId { get; set; }
        public string Data { get; set; }
        public DateTime Expire { get; set; }
    }
}
