namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A promotional percentage discount applied to the offer.
	/// </summary>
	public class OfferProgramConfigurationPromotionsDiscountFunding : BaseClass
	{
		/// <summary>
		/// The percentage discount on the offer.
		/// </summary>
		[JsonProperty("percentage")]
		[Minimum(0)]
		[Maximum(100)]
		public long Percentage { get; set; } 
	}
}
