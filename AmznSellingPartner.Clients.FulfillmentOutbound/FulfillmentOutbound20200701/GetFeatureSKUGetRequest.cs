namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/fba/outbound/2020-07-01/features/inventory/{featureName}/{sellerSku}")]
	public class GetFeatureSKUGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The marketplace for which to return the count.
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; } 

		/// <summary>
		/// The name of the feature.
		/// </summary>
		[InPath("featureName")]
		[IsRequired]
		public string FeatureName { get; set; } 

		/// <summary>
		/// Used to identify an item in the given marketplace. `SellerSKU` is qualified by the seller's `SellerId`,
		/// which is included with every operation that you submit.
		/// </summary>
		[InPath("sellerSku")]
		[IsRequired]
		public string SellerSku { get; set; } 
	}
}
