namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The payload for the getShipmentDocuments operation.
	/// </summary>
	public class GetShipmentDocumentsResult : BaseClass
	{
		[JsonProperty("shipmentId")]
		[IsRequired]
		public ShipmentId ShipmentId { get; set; } 

		[JsonProperty("packageDocumentDetail")]
		[IsRequired]
		public PackageDocumentDetail PackageDocumentDetail { get; set; } 
	}
}
