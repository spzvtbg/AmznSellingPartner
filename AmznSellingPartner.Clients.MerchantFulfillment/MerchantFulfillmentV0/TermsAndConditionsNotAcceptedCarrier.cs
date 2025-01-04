namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A carrier whose terms and conditions have not been accepted by the seller.
	/// </summary>
	public class TermsAndConditionsNotAcceptedCarrier : BaseClass
	{
		/// <summary>
		/// The name of the carrier.
		/// </summary>
		[JsonProperty("CarrierName")]
		[IsRequired]
		public string CarrierName { get; set; } 
	}
}
