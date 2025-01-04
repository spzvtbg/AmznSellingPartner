namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using System;
	using System.Threading.Tasks;

	public class FbaOutboundClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Returns a list of fulfillment order previews based on shipping criteria that you specify.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The table above indicates the default rate and burst values for this operation. Selling partners whose
		/// business demands require higher throughput may have higher rate and burst values than those shown here.
		/// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://deve
		/// loper-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetFulfillmentPreviewPostResponse> GetFulfillmentPreviewAsync(GetFulfillmentPreviewPostRequest request)
		    => await this.SendAsync<GetFulfillmentPreviewPostResponse>(request);

		/// <summary>
		/// Returns delivery options that include an estimated delivery date and offer expiration, based on criteria
		/// that you specify.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 30 |
		/// The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to
		/// the requested operation, when available. The table above indicates the default rate and burst values
		/// for this operation. Selling partners whose business demands require higher throughput may have higher
		/// rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limit
		/// s-in-the-sp-api).
		/// </summary>
		public async Task<DeliveryOffersPostResponse> DeliveryOffersAsync(DeliveryOffersPostRequest request)
		    => await this.SendAsync<DeliveryOffersPostResponse>(request);

		/// <summary>
		/// Returns a list of fulfillment orders fulfilled after (or at) a specified date-time, or indicated by the
		/// next token parameter.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 |
		/// 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// to the requested operation, when available. The table above indicates the default rate and burst values
		/// for this operation. Selling partners whose business demands require higher throughput may have higher
		/// rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limit
		/// s-in-the-sp-api)
		/// </summary>
		public async Task<ListAllFulfillmentOrdersGetResponse> ListAllFulfillmentOrdersAsync(ListAllFulfillmentOrdersGetRequest request)
		    => await this.SendAsync<ListAllFulfillmentOrdersGetResponse>(request);

		/// <summary>
		/// Requests that Amazon ship items from the seller's inventory in Amazon's fulfillment network to a destination
		/// address.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation, when
		/// available. The table above indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may have higher rate and burst values than those shown
		/// here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https:
		/// //developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<CreateFulfillmentOrderPostResponse> CreateFulfillmentOrderAsync(CreateFulfillmentOrderPostRequest request)
		    => await this.SendAsync<CreateFulfillmentOrderPostResponse>(request);

		/// <summary>
		/// Returns delivery tracking information for a package in an outbound shipment for a Multi-Channel Fulfillment
		/// order.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation, when
		/// available. The table above indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may have higher rate and burst values than those shown
		/// here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https:
		/// //developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetPackageTrackingDetailsGetResponse> GetPackageTrackingDetailsAsync(GetPackageTrackingDetailsGetRequest request)
		    => await this.SendAsync<GetPackageTrackingDetailsGetResponse>(request);

		/// <summary>
		/// Returns a list of return reason codes for a seller SKU in a given marketplace. The parameters for this
		/// operation may contain special characters that require URL encoding. To avoid errors with SKUs when encoding
		/// URLs, refer to [URL Encoding](https://developer-docs.amazon.com/sp-api/docs/url-encoding).  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The table above indicates the default rate and burst values for this operation. Selling partners whose
		/// business demands require higher throughput may have higher rate and burst values than those shown here.
		/// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://deve
		/// loper-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<ListReturnReasonCodesGetResponse> ListReturnReasonCodesAsync(ListReturnReasonCodesGetRequest request)
		    => await this.SendAsync<ListReturnReasonCodesGetResponse>(request);

		/// <summary>
		/// Creates a fulfillment return.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ----
		/// | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were
		/// applied to the requested operation, when available. The table above indicates the default rate and burst
		/// values for this operation. Selling partners whose business demands require higher throughput may have
		/// higher rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate
		/// Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rat
		/// e-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateFulfillmentReturnPutResponse> CreateFulfillmentReturnAsync(CreateFulfillmentReturnPutRequest request)
		    => await this.SendAsync<CreateFulfillmentReturnPutResponse>(request);

		/// <summary>
		/// Returns the fulfillment order indicated by the specified order identifier.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns
		/// the usage plan rate limits that were applied to the requested operation, when available. The table above
		/// indicates the default rate and burst values for this operation. Selling partners whose business demands
		/// require higher throughput may have higher rate and burst values than those shown here. For more information,
		/// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/
		/// sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetFulfillmentOrderGetResponse> GetFulfillmentOrderAsync(GetFulfillmentOrderGetRequest request)
		    => await this.SendAsync<GetFulfillmentOrderGetResponse>(request);

		/// <summary>
		/// Updates and/or requests shipment for a fulfillment order with an order hold on it.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The table above indicates the default rate and burst values for this operation. Selling partners whose
		/// business demands require higher throughput may have higher rate and burst values than those shown here.
		/// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://deve
		/// loper-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<UpdateFulfillmentOrderPutResponse> UpdateFulfillmentOrderAsync(UpdateFulfillmentOrderPutRequest request)
		    => await this.SendAsync<UpdateFulfillmentOrderPutResponse>(request);

		/// <summary>
		/// Requests that Amazon stop attempting to fulfill the fulfillment order indicated by the specified order
		/// identifier.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The
		/// `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the
		/// requested operation, when available. The table above indicates the default rate and burst values for
		/// this operation. Selling partners whose business demands require higher throughput may have higher rate
		/// and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in
		/// the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-i
		/// n-the-sp-api).
		/// </summary>
		public async Task<CancelFulfillmentOrderPutResponse> CancelFulfillmentOrderAsync(CancelFulfillmentOrderPutRequest request)
		    => await this.SendAsync<CancelFulfillmentOrderPutResponse>(request);

		/// <summary>
		/// Requests that Amazon update the status of an order in the sandbox testing environment. This is a sandbox-only
		/// operation and must be directed to a sandbox endpoint. Refer to [Fulfillment Outbound Dynamic Sandbox
		/// Guide](https://developer-docs.amazon.com/sp-api/docs/fulfillment-outbound-dynamic-sandbox-guide) and
		/// [Selling Partner API sandbox](https://developer-docs.amazon.com/sp-api/docs/the-selling-partner-api-sandbox)
		/// for more information.
		/// </summary>
		public async Task<SubmitFulfillmentOrderStatusUpdatePutResponse> SubmitFulfillmentOrderStatusUpdateAsync(SubmitFulfillmentOrderStatusUpdatePutRequest request)
		    => await this.SendAsync<SubmitFulfillmentOrderStatusUpdatePutResponse>(request);

		/// <summary>
		/// Returns a list of features available for Multi-Channel Fulfillment orders in the marketplace you specify,
		/// and whether the seller for which you made the call is enrolled for each feature.  **Usage Plan:**  |
		/// Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The table above indicates the default rate and burst values for this operation. Selling partners whose
		/// business demands require higher throughput may have higher rate and burst values than those shown here.
		/// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://deve
		/// loper-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetFeaturesGetResponse> GetFeaturesAsync(GetFeaturesGetRequest request)
		    => await this.SendAsync<GetFeaturesGetResponse>(request);

		/// <summary>
		/// Returns a list of inventory items that are eligible for the fulfillment feature you specify.  **Usage
		/// Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation, when
		/// available. The table above indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may have higher rate and burst values than those shown
		/// here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https:
		/// //developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)..
		/// </summary>
		public async Task<GetFeatureInventoryGetResponse> GetFeatureInventoryAsync(GetFeatureInventoryGetRequest request)
		    => await this.SendAsync<GetFeatureInventoryGetResponse>(request);

		/// <summary>
		/// Returns the number of items with the sellerSKU you specify that can have orders fulfilled using the specified
		/// feature. Note that if the sellerSKU isn't eligible, the response will contain an empty skuInfo object.
		/// The parameters for this operation may contain special characters that require URL encoding. To avoid
		/// errors with SKUs when encoding URLs, refer to [URL Encoding](https://developer-docs.amazon.com/sp-api/docs/url-encoding).
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation, when
		/// available. The table above indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may have higher rate and burst values than those shown
		/// here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https:
		/// //developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetFeatureSKUGetResponse> GetFeatureSKUAsync(GetFeatureSKUGetRequest request)
		    => await this.SendAsync<GetFeatureSKUGetResponse>(request);
	}
}
