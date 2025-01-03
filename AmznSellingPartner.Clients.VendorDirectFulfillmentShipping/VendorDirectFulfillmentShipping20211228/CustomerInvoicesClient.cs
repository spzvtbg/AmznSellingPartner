namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using System;
	using System.Threading.Tasks;

	public class CustomerInvoicesClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns a list of customer invoices created during a time frame that you specify. You define the time
		/// frame using the createdAfter and createdBefore parameters. You must use both of these parameters. The
		/// date range to search must be no more than 7 days.  **Usage Plan:**  | Rate (requests per second) | Burst
		/// | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate
		/// limits that were applied to the requested operation, when available. The preceding table indicates the
		/// default rate and burst values for this operation. Selling partners whose business demands require higher
		/// throughput may have higher rate and burst values then those shown here. For more information, refer to
		/// [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/do
		/// cs/usage-plans-and-rate-limits).
		/// </summary>
		public async Task<GetCustomerInvoicesGetResponse> GetCustomerInvoicesAsync(GetCustomerInvoicesGetRequest request)
		    => await this.SendAsync<GetCustomerInvoicesGetResponse>(request);

		/// <summary>
		/// Returns a customer invoice based on the purchaseOrderNumber that you specify.  **Usage Plan:**  | Rate
		/// (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header
		/// returns the usage plan rate limits that were applied to the requested operation, when available. The
		/// preceding table indicates the default rate and burst values for this operation. Selling partners whose
		/// business demands require higher throughput may have higher rate and burst values then those shown here.
		/// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://deve
		/// loper-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits).
		/// </summary>
		public async Task<GetCustomerInvoiceGetResponse> GetCustomerInvoiceAsync(GetCustomerInvoiceGetRequest request)
		    => await this.SendAsync<GetCustomerInvoiceGetResponse>(request);
	}
}
