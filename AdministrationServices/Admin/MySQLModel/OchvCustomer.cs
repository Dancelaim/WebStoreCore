using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCustomer
    {
        public int CustomerId { get; set; }
        public int CustomerGroupId { get; set; }
        public int StoreId { get; set; }
        public int LanguageId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string ProfileImage { get; set; }
        public string Fax { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Cart { get; set; }
        public string Wishlist { get; set; }
        public bool Newsletter { get; set; }
        public int AddressId { get; set; }
        public string CustomField { get; set; }
        public string Ip { get; set; }
        public bool Status { get; set; }
        public bool Safe { get; set; }
        public string Token { get; set; }
        public string Code { get; set; }
        public DateTime DateAdded { get; set; }
        public string Image { get; set; }
        public string Socnetauth2Identity { get; set; }
        public string Socnetauth2Link { get; set; }
        public string Socnetauth2Provider { get; set; }
        public string Socnetauth2Data { get; set; }
    }
}
