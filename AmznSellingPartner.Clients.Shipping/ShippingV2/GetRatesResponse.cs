namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the getRates operation
	/// </summary>
	public class GetRatesResponse : BaseClass
	{
		[JsonProperty("payload")]
		public GetRatesResult Payload { get; set; }
	}
}
