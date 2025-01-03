namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using System;
	using System.Threading.Tasks;

	public class VendorOrdersClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns a list of purchase orders created during the time frame that you specify. You define the time frame us
		/// ng the createdAfter and createdBefore parameters. You must use both parameters. You can choose to get only the
		/// purchase order numbers by setting the includeDetails parameter to false. In that case, the operation returns a
		/// list of purchase order numbers. You can then call the getOrder operation to return the details of a specific o
		/// der.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLim
		/// t-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when
		/// available. The table above indicates the default rate and burst values for this operation. Selling partners wh
		/// se business demands require higher throughput may see higher rate and burst values then those shown here. For
		/// ore information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-
		/// n-the-sp-api).
		/// </summary>
		public async Task<GetOrdersGetResponse> GetOrdersAsync(GetOrdersGetRequest request)
		    => await this.SendAsync<GetOrdersGetResponse>(request);

		/// <summary>
		/// Returns purchase order information for the purchaseOrderNumber that you specify.  **Usage Plan:**  | Rate (req
		/// ests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns t
		/// e usage plan rate limits that were applied to the requested operation, when available. The table above indicat
		/// s the default rate and burst values for this operation. Selling partners whose business demands require higher
		/// throughput may see higher rate and burst values then those shown here. For more information, see [Usage Plans
		/// nd Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetOrderGetResponse> GetOrderAsync(GetOrderGetRequest request)
		    => await this.SendAsync<GetOrderGetResponse>(request);

		/// <summary>
		/// Submits acknowledgements for one or more purchase orders.  **Usage Plan:**  | Rate (requests per second) | Bur
		/// t | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limi
		/// s that were applied to the requested operation, when available. The table above indicates the default rate and
		/// burst values for this operation. Selling partners whose business demands require higher throughput may see hig
		/// er rate and burst values then those shown here. For more information, see [Usage Plans and Rate Limits in the
		/// elling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<SubmitAcknowledgementPostResponse> SubmitAcknowledgementAsync(SubmitAcknowledgementPostRequest request)
		    => await this.SendAsync<SubmitAcknowledgementPostResponse>(request);
	}
}
