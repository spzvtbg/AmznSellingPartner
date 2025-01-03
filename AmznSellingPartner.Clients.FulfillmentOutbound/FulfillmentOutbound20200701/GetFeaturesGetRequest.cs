namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/fba/outbound/2020-07-01/features")]
	public class GetFeaturesGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The marketplace for which to return the list of features.
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }
	}
}
