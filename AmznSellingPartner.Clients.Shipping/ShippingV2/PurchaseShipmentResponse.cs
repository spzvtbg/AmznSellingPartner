namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the purchaseShipment operation.
	/// </summary>
	public class PurchaseShipmentResponse : BaseClass
	{
		[JsonProperty("payload")]
		public PurchaseShipmentResult Payload { get; set; } 
	}
}
