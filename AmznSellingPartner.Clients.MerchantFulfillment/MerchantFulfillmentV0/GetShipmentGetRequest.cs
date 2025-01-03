namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/mfn/v0/shipments/{shipmentId}")]
	public class GetShipmentGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The Amazon-defined shipment identifier for the shipment.
		/// </summary>
		[InPath("shipmentId")]
		[IsRequired]
		[Pattern("[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}")]
		[JsonProperty("shipmentId")]
		public string ShipmentId { get; set; }
	}
}
