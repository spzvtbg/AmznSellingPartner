namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A carrier who is temporarily unavailable, most likely due to a service outage experienced by the car
	/// rier.
	/// </summary>
	public class TemporarilyUnavailableCarrier : BaseClass
	{
		/// <summary>
		/// The name of the carrier.
		/// </summary>
		[IsRequired]
		[JsonProperty("CarrierName")]
		public string CarrierName { get; set; }
	}
}
