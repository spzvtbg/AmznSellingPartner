namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using System;
	using System.Threading.Tasks;

	public class VendorOrdersClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns a list of purchase orders created or changed during the time frame that you specify. You define
		/// the time frame using the `createdAfter`, `createdBefore`, `changedAfter` and `changedBefore` parameters.
		/// The date range to search must not be more than 7 days. You can choose to get only the purchase order
		/// numbers by setting `includeDetails` to false. You can then use the `getPurchaseOrder` operation to receive
		/// details for a specific purchase order.  **Usage Plan:**  | Rate (requests per second) | Burst | | ----
		/// | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
		/// that were applied to the requested operation, when available. The preceding table indicates the default
		/// rate and burst values for this operation. Selling partners whose business demands require higher throughput
		/// may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans
		/// and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plan
		/// s-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetPurchaseOrdersGetResponse> GetPurchaseOrdersAsync(GetPurchaseOrdersGetRequest request)
		    => await this.SendAsync<GetPurchaseOrdersGetResponse>(request);

		/// <summary>
		/// Returns a purchase order based on the `purchaseOrderNumber` value that you specify.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The preceding table indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may have higher rate and burst values than those shown
		/// here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https:
		/// //developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetPurchaseOrderGetResponse> GetPurchaseOrderAsync(GetPurchaseOrderGetRequest request)
		    => await this.SendAsync<GetPurchaseOrderGetResponse>(request);

		/// <summary>
		/// Submits acknowledgements for one or more purchase orders.  **Usage Plan:**  | Rate (requests per second)
		/// | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage
		/// plan rate limits that were applied to the requested operation, when available. The preceding table indicates
		/// the default rate and burst values for this operation. Selling partners whose business demands require
		/// higher throughput may have higher rate and burst values than those shown here. For more information,
		/// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/
		/// sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<SubmitAcknowledgementPostResponse> SubmitAcknowledgementAsync(SubmitAcknowledgementPostRequest request)
		    => await this.SendAsync<SubmitAcknowledgementPostResponse>(request);

		/// <summary>
		/// Returns purchase order statuses based on the filters that you specify. Date range to search must not
		/// be more than 7 days. You can return a list of purchase order statuses using the available filters, or
		/// a single purchase order status by providing the purchase order number.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns
		/// the usage plan rate limits that were applied to the requested operation, when available. The preceding
		/// table indicates the default rate and burst values for this operation. Selling partners whose business
		/// demands require higher throughput may have higher rate and burst values than those shown here. For more
		/// information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-doc
		/// s.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetPurchaseOrdersStatusGetResponse> GetPurchaseOrdersStatusAsync(GetPurchaseOrdersStatusGetRequest request)
		    => await this.SendAsync<GetPurchaseOrdersStatusGetResponse>(request);
	}
}
