namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/vendor/directFulfillment/shipping/2021-12-28/shipmentConfirmations")]
	public class SubmitShipmentConfirmationsPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// Request body containing the shipment confirmations data
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public SubmitShipmentConfirmationsRequest Body { get; set; }
	}
}
