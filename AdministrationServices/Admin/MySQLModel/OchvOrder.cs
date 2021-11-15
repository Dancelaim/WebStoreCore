using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvOrder
    {
        public int OrderId { get; set; }
        public int InvoiceNo { get; set; }
        public string InvoicePrefix { get; set; }
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreUrl { get; set; }
        public int CustomerId { get; set; }
        public int CustomerGroupId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string CustomField { get; set; }
        public string PaymentFirstname { get; set; }
        public string PaymentLastname { get; set; }
        public string PaymentCompany { get; set; }
        public string PaymentAddress1 { get; set; }
        public string PaymentAddress2 { get; set; }
        public string PaymentCity { get; set; }
        public string PaymentPostcode { get; set; }
        public string PaymentCountry { get; set; }
        public int PaymentCountryId { get; set; }
        public string PaymentZone { get; set; }
        public int PaymentZoneId { get; set; }
        public string PaymentAddressFormat { get; set; }
        public string PaymentCustomField { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentCode { get; set; }
        public string ShippingFirstname { get; set; }
        public string ShippingLastname { get; set; }
        public string ShippingCompany { get; set; }
        public string ShippingAddress1 { get; set; }
        public string ShippingAddress2 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingPostcode { get; set; }
        public string ShippingCountry { get; set; }
        public int ShippingCountryId { get; set; }
        public string ShippingZone { get; set; }
        public int ShippingZoneId { get; set; }
        public string ShippingAddressFormat { get; set; }
        public string ShippingCustomField { get; set; }
        public string ShippingMethod { get; set; }
        public string ShippingCode { get; set; }
        public string Comment { get; set; }
        public decimal Total { get; set; }
        public int OrderStatusId { get; set; }
        public int AffiliateId { get; set; }
        public decimal Commission { get; set; }
        public int MarketingId { get; set; }
        public string Tracking { get; set; }
        public int LanguageId { get; set; }
        public int CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public decimal CurrencyValue { get; set; }
        public string Ip { get; set; }
        public string ForwardedIp { get; set; }
        public string UserAgent { get; set; }
        public string AcceptLanguage { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public bool SendEmail { get; set; }
        public DateTime DateSendEmail { get; set; }
    }
}
