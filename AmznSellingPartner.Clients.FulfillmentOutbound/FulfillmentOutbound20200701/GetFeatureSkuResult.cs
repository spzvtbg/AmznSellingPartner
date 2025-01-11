namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The payload for the `getFeatureSKU` operation.
	/// </summary>
	public class GetFeatureSkuResult : BaseClass
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
		/// When true, the seller SKU is eligible for the requested feature.
		/// </summary>
		[JsonProperty("isEligible")]
		[IsRequired]
		public bool IsEligible { get; set; } 

		/// <summary>
		/// A list of one or more reasons that the seller SKU is ineligibile for the feature.  Possible
		/// values: * `MERCHANT_NOT_ENROLLED` - The merchant isn't enrolled for the feature. * `SKU_NOT_ELIGIBLE`
		/// - The SKU doesn't reside in a warehouse that supports the feature. * `INVALID_SKU` - There
		/// is an issue with the SKU provided.
		/// </summary>
		[JsonProperty("ineligibleReasons")]
		public List<string> IneligibleReasons { get; set; } 

		/// <summary>
		/// Information about the SKU, including the count available, identifiers, and a list of overlapping
		/// SKUs that share the same inventory pool.
		/// </summary>
		[JsonProperty("skuInfo")]
		public FeatureSku SkuInfo { get; set; } 
	}
}
