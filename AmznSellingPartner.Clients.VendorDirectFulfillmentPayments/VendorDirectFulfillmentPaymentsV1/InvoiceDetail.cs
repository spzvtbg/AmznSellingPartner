namespace AmznSellingPartner.Clients.VendorDirectFulfillmentPayments.VendorDirectFulfillmentPaymentsV1
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// Represents the details of an invoice, including invoice number, date, parties involved, payment
    /// terms, totals, taxes, charges, and line items.
    /// </summary>
    public class InvoiceDetail : BaseClass
    {
        /// <summary>
        /// The unique invoice number.
        /// </summary>
        [JsonProperty("invoiceNumber")]
        [IsRequired]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Invoice date.
        /// </summary>
        [JsonProperty("invoiceDate")]
        [IsRequired]
        public DateTimeValue InvoiceDate { get; set; }

        /// <summary>
        /// An additional unique reference number used for regulatory or other purposes.
        /// </summary>
        [JsonProperty("referenceNumber")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Name, address and tax details of the party receiving the payment of this invoice.
        /// </summary>
        [JsonProperty("remitToParty")]
        [IsRequired]
        public PartyIdentification RemitToParty { get; set; }

        /// <summary>
        /// Warehouse code of the vendor as in the order.
        /// </summary>
        [JsonProperty("shipFromParty")]
        [IsRequired]
        public PartyIdentification ShipFromParty { get; set; }

        /// <summary>
        /// Name, address and tax details of the party to whom this invoice is issued.
        /// </summary>
        [JsonProperty("billToParty")]
        public PartyIdentification BillToParty { get; set; }

        /// <summary>
        /// Ship-to country code.
        /// </summary>
        [JsonProperty("shipToCountryCode")]
        public string ShipToCountryCode { get; set; }

        /// <summary>
        /// The payment terms for the invoice.
        /// </summary>
        [JsonProperty("paymentTermsCode")]
        public string PaymentTermsCode { get; set; }

        /// <summary>
        /// Total amount details of the invoice.
        /// </summary>
        [JsonProperty("invoiceTotal")]
        [IsRequired]
        public Money InvoiceTotal { get; set; }

        /// <summary>
        /// Individual tax details per line item.
        /// </summary>
        [JsonProperty("taxTotals")]
        public List<TaxDetail> TaxTotals { get; set; }

        /// <summary>
        /// Additional details provided by the selling party, for tax-related or other purposes.
        /// </summary>
        [JsonProperty("additionalDetails")]
        public List<AdditionalDetails> AdditionalDetails { get; set; }

        /// <summary>
        /// Total charge amount details for all line items.
        /// </summary>
        [JsonProperty("chargeDetails")]
        public List<ChargeDetails> ChargeDetails { get; set; }

        /// <summary>
        /// Provides the details of the items in this invoice.
        /// </summary>
        [JsonProperty("items")]
        [IsRequired]
        public List<InvoiceItem> Items { get; set; }
    }
}
