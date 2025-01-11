namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/vendor/payments/v1/invoices")]
	public class AmznSubmitInvoicesRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request body containing the invoice data to submit.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public SubmitInvoicesRequest Body { get; set; } 
	}
}
