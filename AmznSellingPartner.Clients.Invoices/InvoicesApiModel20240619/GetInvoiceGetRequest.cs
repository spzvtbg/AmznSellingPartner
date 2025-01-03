namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/tax/invoices/2024-06-19/invoices/{invoiceId}")]
	public class GetInvoiceGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The marketplace from which you want the invoice.
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// The invoice identifier.
		/// </summary>
		[InPath("invoiceId")]
		[IsRequired]
		[JsonProperty("invoiceId")]
		public string InvoiceId { get; set; }
	}
}
