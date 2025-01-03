namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/fba/outbound/brazil/v0/shipments/{shipmentId}")]
	public class GetShipmentDetailsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the shipment. Get this value from the FBAOutboundShipmentStatus notification. For
		/// information about subscribing to notifications, see the [Notifications API Use Case Guide](doc:notif
		/// ications-api-v1-use-case-guide).
		/// </summary>
		[InPath("shipmentId")]
		[IsRequired]
		[JsonProperty("shipmentId")]
		public string ShipmentId { get; set; }
	}
}
