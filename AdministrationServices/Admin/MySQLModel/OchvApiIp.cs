using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvApiIp
    {
        public int ApiIpId { get; set; }
        public int ApiId { get; set; }
        public string Ip { get; set; }
    }
}
