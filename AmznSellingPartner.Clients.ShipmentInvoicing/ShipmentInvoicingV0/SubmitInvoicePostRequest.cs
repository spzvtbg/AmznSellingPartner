namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/fba/outbound/brazil/v0/shipments/{shipmentId}/invoice")]
	public class SubmitInvoicePostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the shipment.
		/// </summary>
		[InPath("shipmentId")]
		[IsRequired]
		public string ShipmentId { get; set; }

		[InBody("body")]
		[IsRequired]
		public SubmitInvoiceRequest Body { get; set; }
	}
}
