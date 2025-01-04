namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The payload for the `getEligibileInventory` operation.
	/// </summary>
	public class GetFeatureInventoryResult : BaseClass
	{
		/// <summary>
		/// The requested marketplace.
		/// </summary>
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; } 

		/// <summary>
		/// The name of the feature.
		/// </summary>
		[JsonProperty("featureName")]
		[IsRequired]
		public string FeatureName { get; set; } 

		/// <summary>
		/// When present and not empty, pass this string token in the next request to return the next response p
		/// age.
		/// </summary>
		[JsonProperty("nextToken")]
		public string NextToken { get; set; } 

		/// <summary>
		/// An array of SKUs eligible for this feature and the quantity available.
		/// </summary>
		[JsonProperty("featureSkus")]
		public List<FeatureSku> FeatureSkus { get; set; } 
	}
}
