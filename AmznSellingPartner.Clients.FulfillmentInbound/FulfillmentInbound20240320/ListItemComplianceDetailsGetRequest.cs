namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpGet("/inbound/fba/2024-03-20/items/compliance")]
	public class ListItemComplianceDetailsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// A list of merchant SKUs, a merchant-supplied identifier of a specific SKU.
		/// </summary>
		[InQuery("mskus")]
		[IsRequired]
		[MinItems(1)]
		[MaxItems(100)]
		public CsvValue<string> Mskus { get; set; }

		/// <summary>
		/// The Marketplace ID. For a list of possible values, refer to [Marketplace IDs](https://developer-docs
		/// .amazon.com/sp-api/docs/marketplace-ids).
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(20)]
		public string MarketplaceId { get; set; }
	}
}
