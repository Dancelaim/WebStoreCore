using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCustomerAuthentication
    {
        public int CustomerAuthenticationId { get; set; }
        public int CustomerId { get; set; }
        public string Provider { get; set; }
        public string Identifier { get; set; }
        public string WebSiteUrl { get; set; }
        public string ProfileUrl { get; set; }
        public string PhotoUrl { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Language { get; set; }
        public string Age { get; set; }
        public string BirthDay { get; set; }
        public string BirthMonth { get; set; }
        public string BirthYear { get; set; }
        public string Email { get; set; }
        public string EmailVerified { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
