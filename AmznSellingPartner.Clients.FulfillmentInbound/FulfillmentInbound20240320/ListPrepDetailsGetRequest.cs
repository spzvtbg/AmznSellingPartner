namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	[HttpGet("/inbound/fba/2024-03-20/items/prepDetails")]
	public class ListPrepDetailsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The marketplace ID. For a list of possible values, refer to [Marketplace IDs](https://developer-docs
		/// .amazon.com/sp-api/docs/marketplace-ids).
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(20)]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// A list of merchant SKUs, a merchant-supplied identifier of a specific SKU.
		/// </summary>
		[InQuery("mskus")]
		[IsRequired]
		[MinItems(1)]
		[MaxItems(100)]
		[JsonProperty("mskus")]
		public CsvValue<string> Mskus { get; set; }
	}
}
