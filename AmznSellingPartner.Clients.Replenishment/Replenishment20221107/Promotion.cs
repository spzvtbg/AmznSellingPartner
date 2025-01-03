namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using Newtonsoft.Json;

	/// <summary>
	/// Offer promotions to include in the result filter criteria
	/// </summary>
	public class Promotion : BaseClass
	{
		/// <summary>
		/// A base discount set by the selling partner on the offer
		/// </summary>
		[JsonProperty("sellingPartnerFundedBaseDiscount")]
		public DiscountFunding SellingPartnerFundedBaseDiscount { get; set; }

		/// <summary>
		/// A tiered discount set by the selling partner on the offer
		/// </summary>
		[JsonProperty("sellingPartnerFundedTieredDiscount")]
		public DiscountFunding SellingPartnerFundedTieredDiscount { get; set; }

		/// <summary>
		/// A base discount set by Amazon on the offer
		/// </summary>
		[JsonProperty("amazonFundedBaseDiscount")]
		public DiscountFunding AmazonFundedBaseDiscount { get; set; }

		/// <summary>
		/// A tiered discount set by Amazon on the offer
		/// </summary>
		[JsonProperty("amazonFundedTieredDiscount")]
		public DiscountFunding AmazonFundedTieredDiscount { get; set; }
	}
}
