namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/vendor/shipping/v1/shipments")]
	public class AmznSubmitShipmentsRequest : BaseHttpRequest
	{
		/// <summary>
		/// A request to submit shipment request.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public SubmitShipments Body { get; set; } 
	}
}
