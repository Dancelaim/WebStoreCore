﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    public partial class DbOrder
    {
        public DbOrder()
        {
            OrderProducts = new HashSet<DbOrderProduct>();
        }

        [Key]
        public Guid OrderId { get; set; }
        public Guid? CustomerId { get; set; }
        [StringLength(55)]
        public string Discord { get; set; }
        [StringLength(55)]
        public string Comment { get; set; }
        public Guid? OrderCustomFieldsId { get; set; }
        [StringLength(55)]
        public string Email { get; set; }
        [StringLength(55)]
        public string PaymentMethod { get; set; }
        [StringLength(55)]
        public string PaymentCode { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Total { get; set; }
        [StringLength(55)]
        public string OrderStatus { get; set; }
        [StringLength(55)]
        public string Currency { get; set; }
        [Column("CustomerIP")]
        [StringLength(55)]
        public string CustomerIp { get; set; }
        [StringLength(255)]
        public string UserAgent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderCreateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderUpdateTime { get; set; }
        public bool? EmailSended { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EmailSendTime { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? CarryCoinsSpent { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? CarryCoinsCollected { get; set; }
        public int OrderNumber { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("Orders")]
        public virtual DbCustomer Customer { get; set; }
        [ForeignKey(nameof(OrderCustomFieldsId))]
        [InverseProperty(nameof(DbOrderCustomField.Orders))]
        public virtual DbOrderCustomField OrderCustomFields { get; set; }
        [InverseProperty(nameof(DbOrderProduct.Order))]
        public virtual ICollection<DbOrderProduct> OrderProducts { get; set; }
    }
}
