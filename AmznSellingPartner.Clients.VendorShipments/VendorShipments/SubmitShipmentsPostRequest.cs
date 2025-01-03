namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/vendor/shipping/v1/shipments")]
	public class SubmitShipmentsPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// A request to submit shipment request
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public SubmitShipments Body { get; set; }
	}
}
