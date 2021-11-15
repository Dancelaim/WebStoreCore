using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvOrderShipment
    {
        public int OrderShipmentId { get; set; }
        public int OrderId { get; set; }
        public DateTime DateAdded { get; set; }
        public string ShippingCourierId { get; set; }
        public string TrackingNumber { get; set; }
    }
}
