namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/tax/invoices/2024-06-19/attributes")]
	public class GetInvoicesAttributesGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The marketplace identifier
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }
	}
}
