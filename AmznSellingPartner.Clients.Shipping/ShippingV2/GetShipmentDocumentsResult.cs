namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The payload for the getShipmentDocuments operation
	/// </summary>
	public class GetShipmentDocumentsResult : BaseClass
	{
		[IsRequired]
		[JsonProperty("shipmentId")]
		public ShipmentId ShipmentId { get; set; }

		[IsRequired]
		[JsonProperty("packageDocumentDetail")]
		public PackageDocumentDetail PackageDocumentDetail { get; set; }
	}
}
