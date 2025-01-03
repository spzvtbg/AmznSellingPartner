namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The payload for the OneClickShipment API.
	/// </summary>
	public class OneClickShipmentResult : BaseClass
	{
		[IsRequired]
		[JsonProperty("shipmentId")]
		public ShipmentId ShipmentId { get; set; }

		[IsRequired]
		[JsonProperty("packageDocumentDetails")]
		public PackageDocumentDetailList PackageDocumentDetails { get; set; }

		[IsRequired]
		[JsonProperty("promise")]
		public Promise Promise { get; set; }

		[IsRequired]
		[JsonProperty("carrier")]
		public Carrier Carrier { get; set; }

		[IsRequired]
		[JsonProperty("service")]
		public Service Service { get; set; }

		[IsRequired]
		[JsonProperty("totalCharge")]
		public Currency TotalCharge { get; set; }
	}
}
