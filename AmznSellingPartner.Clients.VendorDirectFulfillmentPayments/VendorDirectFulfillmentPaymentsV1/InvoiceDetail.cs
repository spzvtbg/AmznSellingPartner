namespace AmznSellingPartner.Clients.VendorDirectFulfillmentPayments.VendorDirectFulfillmentPaymentsV1
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Represents the details of an invoice, including invoice number, date, parties involved, payment terms,
	/// totals, taxes, charges, and line items.
	/// </summary>
	public class InvoiceDetail : BaseClass
	{
		/// <summary>
		/// The unique invoice number.
		/// </summary>
		[IsRequired]
		[JsonProperty("invoiceNumber")]
		public string InvoiceNumber { get; set; }

		/// <summary>
		/// Invoice date.
		/// </summary>
		[IsRequired]
		[JsonProperty("invoiceDate")]
		public DateTime InvoiceDate { get; set; }

		/// <summary>
		/// An additional unique reference number used for regulatory or other purposes.
		/// </summary>
		[JsonProperty("referenceNumber")]
		public string ReferenceNumber { get; set; }

		/// <summary>
		/// Name, address and tax details of the party receiving the payment of this invoice.
		/// </summary>
		[IsRequired]
		[JsonProperty("remitToParty")]
		public PartyIdentification RemitToParty { get; set; }

		/// <summary>
		/// Warehouse code of the vendor as in the order.
		/// </summary>
		[IsRequired]
		[JsonProperty("shipFromParty")]
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
		[IsRequired]
		[JsonProperty("invoiceTotal")]
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
		[IsRequired]
		[JsonProperty("items")]
		public List<InvoiceItem> Items { get; set; }
	}
}
