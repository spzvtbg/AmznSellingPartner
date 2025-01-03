namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The parameters for an individual request.
	/// </summary>
	public class FeaturedOfferExpectedPriceRequestParams : BaseClass
	{
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public MarketplaceId MarketplaceId { get; set; }

		[IsRequired]
		[JsonProperty("sku")]
		public Sku Sku { get; set; }
	}
}
