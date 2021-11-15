using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvApiSession
    {
        public int ApiSessionId { get; set; }
        public int ApiId { get; set; }
        public string SessionId { get; set; }
        public string Ip { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
