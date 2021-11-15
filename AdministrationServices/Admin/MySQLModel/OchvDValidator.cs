using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDValidator
    {
        public int ValidatorId { get; set; }
        public string Codename { get; set; }
        public DateTime DateShow { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
