namespace AmznSellingPartner.Clients.VendorDirectFulfillmentPayments.VendorDirectFulfillmentPaymentsV1
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/vendor/directFulfillment/payments/v1/invoices")]
	public class SubmitInvoicePostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request body containing one or more invoices for vendor orders.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public SubmitInvoiceRequest Body { get; set; }
	}
}
