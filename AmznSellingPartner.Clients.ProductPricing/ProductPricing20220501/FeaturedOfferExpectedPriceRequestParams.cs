namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The parameters for an individual request.
	/// </summary>
	public class FeaturedOfferExpectedPriceRequestParams : BaseClass
	{
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public MarketplaceId MarketplaceId { get; set; } 

		[JsonProperty("sku")]
		[IsRequired]
		public Sku Sku { get; set; } 
	}
}
