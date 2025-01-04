namespace AmznSellingPartner.Clients.VendorDirectFulfillmentPayments.VendorDirectFulfillmentPaymentsV1
{
	using System;
	using System.Threading.Tasks;

	public class VendorInvoiceClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Submits one or more invoices for a vendor's direct fulfillment orders.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns
		/// the usage plan rate limits that were applied to the requested operation, when available. The table above
		/// indicates the default rate and burst values for this operation. Selling partners whose business demands
		/// require higher throughput may see higher rate and burst values than those shown here. For more information,
		/// see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-ap
		/// i/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<SubmitInvoicePostResponse> SubmitInvoiceAsync(SubmitInvoicePostRequest request)
		    => await SendAsync<SubmitInvoicePostResponse>(request);
	}
}
