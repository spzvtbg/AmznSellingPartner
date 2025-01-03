namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A Multi-Channel Fulfillment feature.
	/// </summary>
	public class Feature : BaseClass
	{
		/// <summary>
		/// The feature name.
		/// </summary>
		[IsRequired]
		[JsonProperty("featureName")]
		public string FeatureName { get; set; }

		/// <summary>
		/// The feature description.
		/// </summary>
		[IsRequired]
		[JsonProperty("featureDescription")]
		public string FeatureDescription { get; set; }

		/// <summary>
		/// When true, indicates that the seller is eligible to use the feature.
		/// </summary>
		[JsonProperty("sellerEligible")]
		public bool SellerEligible { get; set; }
	}
}
