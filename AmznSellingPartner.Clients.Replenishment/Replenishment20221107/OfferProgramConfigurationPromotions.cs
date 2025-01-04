namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using Newtonsoft.Json;

	/// <summary>
	/// An object which represents all promotions applied to an offer.
	/// </summary>
	public class OfferProgramConfigurationPromotions : BaseClass
	{
		/// <summary>
		/// A base discount set by the selling partner on the offer.
		/// </summary>
		[JsonProperty("sellingPartnerFundedBaseDiscount")]
		public OfferProgramConfigurationPromotionsDiscountFunding SellingPartnerFundedBaseDiscount { get; set; } 

		/// <summary>
		/// A tiered discount set by the selling partner on the offer.
		/// </summary>
		[JsonProperty("sellingPartnerFundedTieredDiscount")]
		public OfferProgramConfigurationPromotionsDiscountFunding SellingPartnerFundedTieredDiscount { get; set; } 

		/// <summary>
		/// A base discount set by Amazon on the offer.
		/// </summary>
		[JsonProperty("amazonFundedBaseDiscount")]
		public OfferProgramConfigurationPromotionsDiscountFunding AmazonFundedBaseDiscount { get; set; } 

		/// <summary>
		/// A tiered discount set by Amazon on the offer.
		/// </summary>
		[JsonProperty("amazonFundedTieredDiscount")]
		public OfferProgramConfigurationPromotionsDiscountFunding AmazonFundedTieredDiscount { get; set; } 
	}
}
