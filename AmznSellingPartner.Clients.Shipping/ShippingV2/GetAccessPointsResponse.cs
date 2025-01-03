namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the GetAccessPoints operation
	/// </summary>
	public class GetAccessPointsResponse : BaseClass
	{
		[JsonProperty("payload")]
		public GetAccessPointsResult Payload { get; set; }
	}
}
