namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the getTracking operation.
	/// </summary>
	public class GetTrackingResponse : BaseClass
	{
		[JsonProperty("payload")]
		public GetTrackingResult Payload { get; set; } 
	}
}
