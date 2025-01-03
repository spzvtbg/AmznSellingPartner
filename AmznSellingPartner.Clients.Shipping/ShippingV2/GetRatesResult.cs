namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The payload for the getRates operation.
	/// </summary>
	public class GetRatesResult : BaseClass
	{
		[IsRequired]
		[JsonProperty("requestToken")]
		public RequestToken RequestToken { get; set; }

		[IsRequired]
		[JsonProperty("rates")]
		public RateList Rates { get; set; }

		[JsonProperty("ineligibleRates")]
		public IneligibleRateList IneligibleRates { get; set; }
	}
}
