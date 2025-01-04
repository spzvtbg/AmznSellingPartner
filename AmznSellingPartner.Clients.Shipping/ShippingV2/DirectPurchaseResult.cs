namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The payload for the directPurchaseShipment operation.
	/// </summary>
	public class DirectPurchaseResult : BaseClass
	{
		[JsonProperty("shipmentId")]
		[IsRequired]
		public ShipmentId ShipmentId { get; set; } 

		[JsonProperty("packageDocumentDetailList")]
		public PackageDocumentDetailList PackageDocumentDetailList { get; set; } 
	}
}
