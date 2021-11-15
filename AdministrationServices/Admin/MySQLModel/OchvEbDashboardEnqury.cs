using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvEbDashboardEnqury
    {
        public int EbDashboardEnquriesId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Enquiry { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
