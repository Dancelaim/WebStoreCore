using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDGdprCookie
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string UserAgent { get; set; }
        public byte Accepted { get; set; }
        public string CookieExtra { get; set; }
        public string AcceptLanguageId { get; set; }
        public DateTime AcceptDate { get; set; }
        public DateTime DeclineDate { get; set; }
    }
}
