namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using System;
	using System.Threading.Tasks;

	public class VendorInvoicesClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Submit new invoices to Amazon.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ----
		/// | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were
		/// applied to the requested operation, when available. The table above indicates the default rate and burst
		/// values for this operation. Selling partners whose business demands require higher throughput may see
		/// higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits
		/// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limit
		/// s-in-the-sp-api).
		/// </summary>
		public async Task<SubmitInvoicesPostResponse> SubmitInvoicesAsync(SubmitInvoicesPostRequest request)
		    => await this.SendAsync<SubmitInvoicesPostResponse>(request);
	}
}
