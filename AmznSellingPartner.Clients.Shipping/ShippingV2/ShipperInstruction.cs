namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The shipper instruction.
	/// </summary>
	public class ShipperInstruction : BaseClass
	{
		/// <summary>
		/// The delivery notes for the shipment
		/// </summary>
		[MaxLength(256)]
		[JsonProperty("deliveryNotes")]
		public string DeliveryNotes { get; set; }
	}
}
