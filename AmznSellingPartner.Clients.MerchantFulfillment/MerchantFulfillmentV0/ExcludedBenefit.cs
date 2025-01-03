namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// An object representing an excluded benefit that is excluded for a shipping offer or rate
	/// </summary>
	public class ExcludedBenefit : BaseClass
	{
		/// <summary>
		/// A benefit that is being excluded from a shipment
		/// </summary>
		[JsonProperty("Benefit")]
		public string Benefit { get; set; }

		[JsonProperty("ReasonCodes")]
		public ExcludedBenefitReasonCodes ReasonCodes { get; set; }
	}
}
