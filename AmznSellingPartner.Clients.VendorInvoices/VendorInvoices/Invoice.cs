namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Represents an invoice or credit note document with details about the transaction, parties involved, and
	/// line items.
	/// </summary>
	public class Invoice : BaseClass
	{
		/// <summary>
		/// Identifies the type of invoice.
		/// </summary>
		[JsonProperty("invoiceType")]
		[IsRequired]
		public InvoiceType InvoiceType { get; set; } 

		/// <summary>
		/// Unique number relating to the charges defined in this document. This will be invoice number if the document
		/// type is Invoice or CreditNote number if the document type is Credit Note. Failure to provide this reference
		/// will result in a rejection.
		/// </summary>
		[JsonProperty("id")]
		[IsRequired]
		public string Id { get; set; } 

		/// <summary>
		/// An additional unique reference number used for regulatory or other purposes.
		/// </summary>
		[JsonProperty("referenceNumber")]
		public string ReferenceNumber { get; set; } 

		/// <summary>
		/// Date when the invoice/credit note information was generated in the origin's accounting system. The invoice
		/// date should be on or after the purchase order creation date.
		/// </summary>
		[JsonProperty("date")]
		[IsRequired]
		public DateTime Date { get; set; } 

		/// <summary>
		/// Name, address and tax details of the party receiving the payment of this invoice.
		/// </summary>
		[JsonProperty("remitToParty")]
		[IsRequired]
		public PartyIdentification RemitToParty { get; set; } 

		/// <summary>
		/// Name, address and tax details of the party receiving a shipment of products.
		/// </summary>
		[JsonProperty("shipToParty")]
		public PartyIdentification ShipToParty { get; set; } 

		/// <summary>
		/// Name, address and tax details of the party sending a shipment of products.
		/// </summary>
		[JsonProperty("shipFromParty")]
		public PartyIdentification ShipFromParty { get; set; } 

		/// <summary>
		/// Name, address and tax details of the party to whom this invoice is issued.
		/// </summary>
		[JsonProperty("billToParty")]
		public PartyIdentification BillToParty { get; set; } 

		/// <summary>
		/// The payment terms for the invoice.
		/// </summary>
		[JsonProperty("paymentTerms")]
		public PaymentTerms PaymentTerms { get; set; } 

		/// <summary>
		/// Total monetary amount charged in the invoice or full value of credit note to be paid including all relevant
		/// taxes. It is the total amount of invoice (including charges, less allowances) before terms discount (if
		/// discount is applicable).
		/// </summary>
		[JsonProperty("invoiceTotal")]
		[IsRequired]
		public Money InvoiceTotal { get; set; } 

		/// <summary>
		/// Total tax amount details for all line items.
		/// </summary>
		[JsonProperty("taxDetails")]
		public List<TaxDetails> TaxDetails { get; set; } 

		/// <summary>
		/// Additional details provided by the selling party, for tax related or other purposes.
		/// </summary>
		[JsonProperty("additionalDetails")]
		public List<AdditionalDetails> AdditionalDetails { get; set; } 

		/// <summary>
		/// Total charge amount details for all line items.
		/// </summary>
		[JsonProperty("chargeDetails")]
		public List<ChargeDetails> ChargeDetails { get; set; } 

		/// <summary>
		/// Total allowance amount details for all line items.
		/// </summary>
		[JsonProperty("allowanceDetails")]
		public List<AllowanceDetails> AllowanceDetails { get; set; } 

		/// <summary>
		/// The list of invoice items.
		/// </summary>
		[JsonProperty("items")]
		public List<InvoiceItem> Items { get; set; } 
	}
}
