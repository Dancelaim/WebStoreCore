using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvCart
    {
        public int CartId { get; set; }
        public int ApiId { get; set; }
        public int CustomerId { get; set; }
        public string SessionId { get; set; }
        public int ProductId { get; set; }
        public int RecurringId { get; set; }
        public string Option { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; }
        public float SelectLevel { get; set; }
        public int Sale { get; set; }
        public string RaidTypeFaction { get; set; }
        public string RaidDateTime { get; set; }
        public string RaidDateTimeUser { get; set; }
    }
}
