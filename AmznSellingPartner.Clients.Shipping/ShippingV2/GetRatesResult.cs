namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The payload for the getRates operation.
	/// </summary>
	public class GetRatesResult : BaseClass
	{
		[JsonProperty("requestToken")]
		[IsRequired]
		public RequestToken RequestToken { get; set; } 

		[JsonProperty("rates")]
		[IsRequired]
		public RateList Rates { get; set; } 

		[JsonProperty("ineligibleRates")]
		public IneligibleRateList IneligibleRates { get; set; } 
	}
}
