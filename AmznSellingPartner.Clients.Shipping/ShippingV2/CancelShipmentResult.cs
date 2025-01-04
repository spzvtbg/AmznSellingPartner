namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The payload for the cancelShipment operation.
	/// </summary>
	public class CancelShipmentResult : BaseClass
	{
		[JsonProperty("")]
		public object AdditionalValue { get; set; }
	}
}
