namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/vendor/directFulfillment/shipping/2021-12-28/shipmentStatusUpdates")]
	public class SubmitShipmentStatusUpdatesPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// Request body containing the shipment status update data.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public SubmitShipmentStatusUpdatesRequest Body { get; set; }
	}
}
