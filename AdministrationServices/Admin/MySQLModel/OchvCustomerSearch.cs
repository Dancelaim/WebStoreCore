using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCustomerSearch
    {
        public int CustomerSearchId { get; set; }
        public int StoreId { get; set; }
        public int LanguageId { get; set; }
        public int CustomerId { get; set; }
        public string Keyword { get; set; }
        public int? CategoryId { get; set; }
        public bool SubCategory { get; set; }
        public bool Description { get; set; }
        public int Products { get; set; }
        public string Ip { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
