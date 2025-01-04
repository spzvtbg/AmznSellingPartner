namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpDelete("/mfn/v0/shipments/{shipmentId}")]
	public class CancelShipmentDeleteRequest : BaseHttpRequest
	{
		/// <summary>
		/// The Amazon-defined shipment identifier for the shipment to cancel.
		/// </summary>
		[InPath("shipmentId")]
		[IsRequired]
		[Pattern("[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}")]
		public string ShipmentId { get; set; }
	}
}
