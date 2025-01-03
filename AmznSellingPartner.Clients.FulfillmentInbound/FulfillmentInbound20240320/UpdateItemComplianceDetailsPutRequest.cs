namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPut("/inbound/fba/2024-03-20/items/compliance")]
	public class UpdateItemComplianceDetailsPutRequest : BaseHttpRequest
	{
		/// <summary>
		/// The Marketplace ID. For a list of possible values, refer to [Marketplace IDs](https://developer-docs
		/// .amazon.com/sp-api/docs/marketplace-ids).
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(20)]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// The body of the request to `updateItemComplianceDetails`.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public UpdateItemComplianceDetailsRequest Body { get; set; }
	}
}
