using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvUser
    {
        public int UserId { get; set; }
        public int UserGroupId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Code { get; set; }
        public string Ip { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
