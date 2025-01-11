namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/vendor/directFulfillment/shipping/2021-12-28/shipmentConfirmations")]
	public class AmznSubmitShipmentConfirmationsRequest : BaseHttpRequest
	{
		/// <summary>
		/// Request body containing the shipment confirmations data.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public SubmitShipmentConfirmationsRequest Body { get; set; } 
	}
}
