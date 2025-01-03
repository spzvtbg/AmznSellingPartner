namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/fba/outbound/brazil/v0/shipments/{shipmentId}/invoice")]
	public class SubmitInvoicePostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the shipment.
		/// </summary>
		[InPath("shipmentId")]
		[IsRequired]
		[JsonProperty("shipmentId")]
		public string ShipmentId { get; set; }

		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public SubmitInvoiceRequest Body { get; set; }
	}
}
