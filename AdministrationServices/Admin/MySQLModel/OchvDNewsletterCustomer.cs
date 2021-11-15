using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvDNewsletterCustomer
    {
        public int CustomerId { get; set; }
        public int LanguageId { get; set; }
        public int StoreId { get; set; }
    }
}
