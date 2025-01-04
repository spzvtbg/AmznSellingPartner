namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Details of the item being invoiced.
	/// </summary>
	public class InvoiceItem : BaseClass
	{
		/// <summary>
		/// Unique number related to this line item.
		/// </summary>
		[JsonProperty("itemSequenceNumber")]
		[IsRequired]
		public int ItemSequenceNumber { get; set; } 

		/// <summary>
		/// Amazon Standard Identification Number (ASIN) of an item.
		/// </summary>
		[JsonProperty("amazonProductIdentifier")]
		public string AmazonProductIdentifier { get; set; } 

		/// <summary>
		/// The vendor selected product identifier of the item. Should be the same as was provided in the purchase
		/// order.
		/// </summary>
		[JsonProperty("vendorProductIdentifier")]
		public string VendorProductIdentifier { get; set; } 

		/// <summary>
		/// Invoiced quantity of this item. Quantity must be greater than zero.
		/// </summary>
		[JsonProperty("invoicedQuantity")]
		[IsRequired]
		public ItemQuantity InvoicedQuantity { get; set; } 

		/// <summary>
		/// The item cost to Amazon, which should match the cost on the order. Price information should not be zero
		/// or negative. It indicates net unit price. Net cost means VAT is not included in cost. If items are priced
		/// by weight, this cost need to be considered in conjunction with netCostUnitOfMeasure. E.g.: 5/LB
		/// </summary>
		[JsonProperty("netCost")]
		[IsRequired]
		public Money NetCost { get; set; } 

		/// <summary>
		/// This field represents weight unit of measure of items that are ordered by cases and supporting priced
		/// by weight.
		/// </summary>
		[JsonProperty("netCostUnitOfMeasure")]
		public NetCostUnitOfMeasure NetCostUnitOfMeasure { get; set; } 

		/// <summary>
		/// The Amazon purchase order number for this invoiced line item. Formatting Notes: 8-character alpha-numeric
		/// code. This value is mandatory only when invoiceType is Invoice, and is not required when invoiceType
		/// is CreditNote.
		/// </summary>
		[JsonProperty("purchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; } 

		/// <summary>
		/// HSN Tax code. The HSN number cannot contain alphabets.
		/// </summary>
		[JsonProperty("hsnCode")]
		public string HsnCode { get; set; } 

		/// <summary>
		/// Details required in order to process a credit note. This information is required only if invoiceType
		/// is CreditNote.
		/// </summary>
		[JsonProperty("creditNoteDetails")]
		public CreditNoteDetails CreditNoteDetails { get; set; } 

		/// <summary>
		/// Individual tax details per line item.
		/// </summary>
		[JsonProperty("taxDetails")]
		public List<TaxDetails> TaxDetails { get; set; } 

		/// <summary>
		/// Individual charge details per line item.
		/// </summary>
		[JsonProperty("chargeDetails")]
		public List<ChargeDetails> ChargeDetails { get; set; } 

		/// <summary>
		/// Individual allowance details per line item.
		/// </summary>
		[JsonProperty("allowanceDetails")]
		public List<AllowanceDetails> AllowanceDetails { get; set; } 
	}
}
