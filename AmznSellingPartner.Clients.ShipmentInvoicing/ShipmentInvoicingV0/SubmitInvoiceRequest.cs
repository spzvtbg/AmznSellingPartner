namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for the submitInvoice operation.
	/// </summary>
	public class SubmitInvoiceRequest : BaseClass
	{
		[IsRequired]
		[JsonProperty("InvoiceContent")]
		public Blob InvoiceContent { get; set; }

		/// <summary>
		/// An Amazon marketplace identifier.
		/// </summary>
		[JsonProperty("MarketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// MD5 sum for validating the invoice data. For more information about calculating this value, see [Working with
		/// ontent-MD5 Checksums](https://docs.developer.amazonservices.com/en_US/dev_guide/DG_MD5.html).
		/// </summary>
		[IsRequired]
		[JsonProperty("ContentMD5Value")]
		public string ContentMD5Value { get; set; }
	}
}
