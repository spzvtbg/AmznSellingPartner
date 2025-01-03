namespace AmznSellingPartner.Clients.Sellers.Sellers
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getAccount` operation
	/// </summary>
	public class Account : BaseClass
	{
		[IsRequired]
		[JsonProperty("marketplaceParticipationList")]
		public MarketplaceParticipationList MarketplaceParticipationList { get; set; }

		/// <summary>
		/// The type of business registered for the seller account
		/// </summary>
		[IsRequired]
		[JsonProperty("businessType")]
		public BusinessType BusinessType { get; set; }

		/// <summary>
		/// The selling plan details
		/// </summary>
		[IsRequired]
		[JsonProperty("sellingPlan")]
		public SellingPlan SellingPlan { get; set; }

		[JsonProperty("business")]
		public Business Business { get; set; }

		[JsonProperty("primaryContact")]
		public PrimaryContact PrimaryContact { get; set; }
	}
}
