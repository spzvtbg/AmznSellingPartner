namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The payload for the purchaseShipment operation
	/// </summary>
	public class PurchaseShipmentResult : BaseClass
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
	}
}
