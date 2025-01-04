namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/vendor/shipping/v1/shipmentConfirmations")]
	public class SubmitShipmentConfirmationsPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// A request to submit shipment confirmation.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public SubmitShipmentConfirmationsRequest Body { get; set; }
	}
}
