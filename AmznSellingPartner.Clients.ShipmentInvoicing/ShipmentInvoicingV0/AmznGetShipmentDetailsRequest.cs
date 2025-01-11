namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/fba/outbound/brazil/v0/shipments/{shipmentId}")]
	public class AmznGetShipmentDetailsRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the shipment. Get this value from the FBAOutboundShipmentStatus notification.
		/// For information about subscribing to notifications, see the [Notifications API Use Case Gu
		/// ide](doc:notifications-api-v1-use-case-guide).
		/// </summary>
		[InPath("shipmentId")]
		[IsRequired]
		public string ShipmentId { get; set; } 
	}
}
