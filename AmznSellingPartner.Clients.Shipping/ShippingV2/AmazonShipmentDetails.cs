namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Amazon shipment information.
	/// </summary>
	public class AmazonShipmentDetails : BaseClass
	{
		/// <summary>
		/// This attribute is required only for a Direct Fulfillment shipment. This is the encrypted shipment
		/// ID.
		/// </summary>
		[JsonProperty("shipmentId")]
		[IsRequired]
		public string ShipmentId { get; set; } 
	}
}
