namespace AmznSellingPartner.Clients.VendorDirectFulfillmentPayments.VendorDirectFulfillmentPaymentsV1
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Provides the details of the items in this invoice.
	/// </summary>
	public class InvoiceItem : BaseClass
	{
		/// <summary>
		/// Numbering of the item on the purchase order. The first item will be 1, the second 2, and so on.
		/// </summary>
		[JsonProperty("itemSequenceNumber")]
		[IsRequired]
		public string ItemSequenceNumber { get; set; }

		/// <summary>
		/// Buyer's standard identification number (ASIN) of an item.
		/// </summary>
		[JsonProperty("buyerProductIdentifier")]
		public string BuyerProductIdentifier { get; set; }

		/// <summary>
		/// The vendor selected product identification of the item.
		/// </summary>
		[JsonProperty("vendorProductIdentifier")]
		public string VendorProductIdentifier { get; set; }

		/// <summary>
		/// Item quantity invoiced.
		/// </summary>
		[JsonProperty("invoicedQuantity")]
		[IsRequired]
		public ItemQuantity InvoicedQuantity { get; set; }

		/// <summary>
		/// Net price (before tax) to vendor with currency details.
		/// </summary>
		[JsonProperty("netCost")]
		[IsRequired]
		public Money NetCost { get; set; }

		/// <summary>
		/// The purchase order number for this order. Formatting Notes: 8-character alpha-numeric code.
		/// </summary>
		[JsonProperty("purchaseOrderNumber")]
		[IsRequired]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// The vendor's order number for this order.
		/// </summary>
		[JsonProperty("vendorOrderNumber")]
		public string VendorOrderNumber { get; set; }

		/// <summary>
		/// Harmonized System of Nomenclature (HSN) tax code. The HSN number cannot contain alphabets.
		/// </summary>
		[JsonProperty("hsnCode")]
		public string HsnCode { get; set; }

		/// <summary>
		/// Individual tax details per line item.
		/// </summary>
		[JsonProperty("taxDetails")]
		public List<TaxDetail> TaxDetails { get; set; }

		/// <summary>
		/// Individual charge details per line item.
		/// </summary>
		[JsonProperty("chargeDetails")]
		public List<ChargeDetails> ChargeDetails { get; set; }
	}
}
