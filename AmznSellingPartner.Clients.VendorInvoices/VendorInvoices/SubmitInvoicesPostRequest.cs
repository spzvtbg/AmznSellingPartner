namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/vendor/payments/v1/invoices")]
	public class SubmitInvoicesPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request body containing the invoice data to submit
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public SubmitInvoicesRequest Body { get; set; }
	}
}
