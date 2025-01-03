namespace AmznSellingPartner.Clients.VendorDirectFulfillmentPayments.VendorDirectFulfillmentPaymentsV1
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request schema for the submitInvoice operation.
	/// </summary>
	public class SubmitInvoiceRequest : BaseClass
	{
		/// <summary>
		/// An array of invoice details to be submitted.
		/// </summary>
		[JsonProperty("invoices")]
		public List<InvoiceDetail> Invoices { get; set; }
	}
}
