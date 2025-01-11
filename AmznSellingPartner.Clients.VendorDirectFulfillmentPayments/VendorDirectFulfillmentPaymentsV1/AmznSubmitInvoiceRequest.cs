namespace AmznSellingPartner.Clients.VendorDirectFulfillmentPayments.VendorDirectFulfillmentPaymentsV1
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/vendor/directFulfillment/payments/v1/invoices")]
	public class AmznSubmitInvoiceRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request body containing one or more invoices for vendor orders.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public SubmitInvoiceRequest Body { get; set; } 
	}
}
