using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCron
    {
        public int CronId { get; set; }
        public string Code { get; set; }
        public string Cycle { get; set; }
        public string Action { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
