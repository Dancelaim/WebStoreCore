using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDGdprPolicy
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Email { get; set; }
        public int PolicyId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
