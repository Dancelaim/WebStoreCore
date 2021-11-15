using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCustomerAffiliate
    {
        public int CustomerId { get; set; }
        public string Company { get; set; }
        public string Website { get; set; }
        public string Tracking { get; set; }
        public decimal Commission { get; set; }
        public string Tax { get; set; }
        public string Payment { get; set; }
        public string Cheque { get; set; }
        public string Paypal { get; set; }
        public string BankName { get; set; }
        public string BankBranchNumber { get; set; }
        public string BankSwiftCode { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountNumber { get; set; }
        public string CustomField { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
