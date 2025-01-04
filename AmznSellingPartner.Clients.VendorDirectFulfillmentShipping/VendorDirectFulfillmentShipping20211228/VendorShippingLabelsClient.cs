namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using System;
	using System.Threading.Tasks;

	public class VendorShippingLabelsClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Returns a list of shipping labels created during the time frame that you specify. Use the `createdAfter`
		/// and `createdBefore` parameters to define the time frame. You must use both of these parameters. The date
		/// range to search must not be more than seven days.  **Usage Plan:**  | Rate (requests per second) | Burst
		/// | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate
		/// limits that were applied to the requested operation, when available. The preceding table indicates the
		/// default rate and burst values for this operation. Selling partners whose business demands require higher
		/// throughput may have higher rate and burst values then those shown here. For more information, refer to
		/// [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/do
		/// cs/usage-plans-and-rate-limits).
		/// </summary>
		public async Task<GetShippingLabelsGetResponse> GetShippingLabelsAsync(GetShippingLabelsGetRequest request)
		    => await SendAsync<GetShippingLabelsGetResponse>(request);

		/// <summary>
		/// Creates a shipping label for a purchase order and returns a `transactionId` for reference.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The preceding table indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may have higher rate and burst values then those shown
		/// here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https:
		/// //developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits).
		/// </summary>
		public async Task<SubmitShippingLabelRequestPostResponse> SubmitShippingLabelRequestAsync(SubmitShippingLabelRequestPostRequest request)
		    => await SendAsync<SubmitShippingLabelRequestPostResponse>(request);

		/// <summary>
		/// Returns a shipping label for the `purchaseOrderNumber` that you specify.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns
		/// the usage plan rate limits that were applied to the requested operation, when available. The preceding
		/// table indicates the default rate and burst values for this operation. Selling partners whose business
		/// demands require higher throughput may have higher rate and burst values then those shown here. For more
		/// information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-doc
		/// s.amazon.com/sp-api/docs/usage-plans-and-rate-limits).
		/// </summary>
		public async Task<GetShippingLabelGetResponse> GetShippingLabelAsync(GetShippingLabelGetRequest request)
		    => await SendAsync<GetShippingLabelGetResponse>(request);

		/// <summary>
		/// Creates shipping labels for a purchase order and returns the labels.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns
		/// the usage plan rate limits that were applied to the requested operation, when available. The preceding
		/// table indicates the default rate and burst values for this operation. Selling partners whose business
		/// demands require higher throughput may have higher rate and burst values then those shown here. For more
		/// information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-doc
		/// s.amazon.com/sp-api/docs/usage-plans-and-rate-limits).
		/// </summary>
		public async Task<CreateShippingLabelsPostResponse> CreateShippingLabelsAsync(CreateShippingLabelsPostRequest request)
		    => await SendAsync<CreateShippingLabelsPostResponse>(request);
	}
}
