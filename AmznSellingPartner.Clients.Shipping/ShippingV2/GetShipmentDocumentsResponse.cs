namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the the getShipmentDocuments operation.
	/// </summary>
	public class GetShipmentDocumentsResponse : BaseClass
	{
		[JsonProperty("payload")]
		public GetShipmentDocumentsResult Payload { get; set; } 
	}
}
