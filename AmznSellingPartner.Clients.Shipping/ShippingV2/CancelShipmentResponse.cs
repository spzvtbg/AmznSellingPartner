namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// Response schema for the cancelShipment operation
	/// </summary>
	public class CancelShipmentResponse : BaseClass
	{
		[JsonProperty("payload")]
		public CancelShipmentResult Payload { get; set; }
	}
}
