namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using System;
	using System.Threading.Tasks;

	public class FbaOutboundClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns a list of fulfillment order previews based on shipping criteria that you specify.  **Usage Plan:**  |
		/// ate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header r
		/// turns the usage plan rate limits that were applied to the requested operation, when available. The table above
		/// indicates the default rate and burst values for this operation. Selling partners whose business demands requir
		/// higher throughput may have higher rate and burst values than those shown here. For more information, refer to
		/// [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-p
		/// ans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetFulfillmentPreviewPostResponse> GetFulfillmentPreviewAsync(GetFulfillmentPreviewPostRequest request)
		    => await this.SendAsync<GetFulfillmentPreviewPostResponse>(request);

		/// <summary>
		/// Returns delivery options that include an estimated delivery date and offer expiration, based on criteria that
		/// ou specify.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 30 |  The `x-amzn-R
		/// teLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation
		/// when available. The table above indicates the default rate and burst values for this operation. Selling partn
		/// rs whose business demands require higher throughput may have higher rate and burst values than those shown her
		/// . For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-do
		/// s.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<DeliveryOffersPostResponse> DeliveryOffersAsync(DeliveryOffersPostRequest request)
		    => await this.SendAsync<DeliveryOffersPostResponse>(request);

		/// <summary>
		/// Returns a list of fulfillment orders fulfilled after (or at) a specified date-time, or indicated by the next t
		/// ken parameter.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amz
		/// -RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operat
		/// on, when available. The table above indicates the default rate and burst values for this operation. Selling pa
		/// tners whose business demands require higher throughput may have higher rate and burst values than those shown
		/// ere. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer
		/// docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<ListAllFulfillmentOrdersGetResponse> ListAllFulfillmentOrdersAsync(ListAllFulfillmentOrdersGetRequest request)
		    => await this.SendAsync<ListAllFulfillmentOrdersGetResponse>(request);

		/// <summary>
		/// Requests that Amazon ship items from the seller's inventory in Amazon's fulfillment network to a destination a
		/// dress.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLi
		/// it-Limit` response header returns the usage plan rate limits that were applied to the requested operation, whe
		/// available. The table above indicates the default rate and burst values for this operation. Selling partners w
		/// ose business demands require higher throughput may have higher rate and burst values than those shown here. Fo
		/// more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.am
		/// zon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<CreateFulfillmentOrderPostResponse> CreateFulfillmentOrderAsync(CreateFulfillmentOrderPostRequest request)
		    => await this.SendAsync<CreateFulfillmentOrderPostResponse>(request);

		/// <summary>
		/// Returns delivery tracking information for a package in an outbound shipment for a Multi-Channel Fulfillment or
		/// er.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit
		/// Limit` response header returns the usage plan rate limits that were applied to the requested operation, when a
		/// ailable. The table above indicates the default rate and burst values for this operation. Selling partners whos
		/// business demands require higher throughput may have higher rate and burst values than those shown here. For m
		/// re information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazo
		/// .com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetPackageTrackingDetailsGetResponse> GetPackageTrackingDetailsAsync(GetPackageTrackingDetailsGetRequest request)
		    => await this.SendAsync<GetPackageTrackingDetailsGetResponse>(request);

		/// <summary>
		/// Returns a list of return reason codes for a seller SKU in a given marketplace. The parameters for this operati
		/// n may contain special characters that require URL encoding. To avoid errors with SKUs when encoding URLs, refe
		/// to [URL Encoding](https://developer-docs.amazon.com/sp-api/docs/url-encoding).  **Usage Plan:**  | Rate (requ
		/// sts per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the
		/// usage plan rate limits that were applied to the requested operation, when available. The table above indicates
		/// the default rate and burst values for this operation. Selling partners whose business demands require higher t
		/// roughput may have higher rate and burst values than those shown here. For more information, refer to [Usage Pl
		/// ns and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-r
		/// te-limits-in-the-sp-api).
		/// </summary>
		public async Task<ListReturnReasonCodesGetResponse> ListReturnReasonCodesAsync(ListReturnReasonCodesGetRequest request)
		    => await this.SendAsync<ListReturnReasonCodesGetResponse>(request);

		/// <summary>
		/// Creates a fulfillment return.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 3
		/// |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the r
		/// quested operation, when available. The table above indicates the default rate and burst values for this operat
		/// on. Selling partners whose business demands require higher throughput may have higher rate and burst values th
		/// n those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](ht
		/// ps://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateFulfillmentReturnPutResponse> CreateFulfillmentReturnAsync(CreateFulfillmentReturnPutRequest request)
		    => await this.SendAsync<CreateFulfillmentReturnPutResponse>(request);

		/// <summary>
		/// Returns the fulfillment order indicated by the specified order identifier.  **Usage Plan:**  | Rate (requests
		/// er second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usag
		/// plan rate limits that were applied to the requested operation, when available. The table above indicates the
		/// efault rate and burst values for this operation. Selling partners whose business demands require higher throug
		/// put may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans a
		/// d Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-l
		/// mits-in-the-sp-api).
		/// </summary>
		public async Task<GetFulfillmentOrderGetResponse> GetFulfillmentOrderAsync(GetFulfillmentOrderGetRequest request)
		    => await this.SendAsync<GetFulfillmentOrderGetResponse>(request);

		/// <summary>
		/// Updates and/or requests shipment for a fulfillment order with an order hold on it.  **Usage Plan:**  | Rate (r
		/// quests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns
		/// he usage plan rate limits that were applied to the requested operation, when available. The table above indica
		/// es the default rate and burst values for this operation. Selling partners whose business demands require highe
		/// throughput may have higher rate and burst values than those shown here. For more information, refer to [Usage
		/// Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-an
		/// -rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<UpdateFulfillmentOrderPutResponse> UpdateFulfillmentOrderAsync(UpdateFulfillmentOrderPutRequest request)
		    => await this.SendAsync<UpdateFulfillmentOrderPutResponse>(request);

		/// <summary>
		/// Requests that Amazon stop attempting to fulfill the fulfillment order indicated by the specified order identif
		/// er.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit
		/// Limit` response header returns the usage plan rate limits that were applied to the requested operation, when a
		/// ailable. The table above indicates the default rate and burst values for this operation. Selling partners whos
		/// business demands require higher throughput may have higher rate and burst values than those shown here. For m
		/// re information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazo
		/// .com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CancelFulfillmentOrderPutResponse> CancelFulfillmentOrderAsync(CancelFulfillmentOrderPutRequest request)
		    => await this.SendAsync<CancelFulfillmentOrderPutResponse>(request);

		/// <summary>
		/// Requests that Amazon update the status of an order in the sandbox testing environment. This is a sandbox-only
		/// peration and must be directed to a sandbox endpoint. Refer to [Fulfillment Outbound Dynamic Sandbox Guide](htt
		/// s://developer-docs.amazon.com/sp-api/docs/fulfillment-outbound-dynamic-sandbox-guide) and [Selling Partner API
		/// sandbox](https://developer-docs.amazon.com/sp-api/docs/the-selling-partner-api-sandbox) for more information.
		/// </summary>
		public async Task<SubmitFulfillmentOrderStatusUpdatePutResponse> SubmitFulfillmentOrderStatusUpdateAsync(SubmitFulfillmentOrderStatusUpdatePutRequest request)
		    => await this.SendAsync<SubmitFulfillmentOrderStatusUpdatePutResponse>(request);

		/// <summary>
		/// Returns a list of features available for Multi-Channel Fulfillment orders in the marketplace you specify, and
		/// hether the seller for which you made the call is enrolled for each feature.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usa
		/// e plan rate limits that were applied to the requested operation, when available. The table above indicates the
		/// default rate and burst values for this operation. Selling partners whose business demands require higher throu
		/// hput may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans
		/// nd Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-
		/// imits-in-the-sp-api).
		/// </summary>
		public async Task<GetFeaturesGetResponse> GetFeaturesAsync(GetFeaturesGetRequest request)
		    => await this.SendAsync<GetFeaturesGetResponse>(request);

		/// <summary>
		/// Returns a list of inventory items that are eligible for the fulfillment feature you specify.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` response heade
		/// returns the usage plan rate limits that were applied to the requested operation, when available. The table ab
		/// ve indicates the default rate and burst values for this operation. Selling partners whose business demands req
		/// ire higher throughput may have higher rate and burst values than those shown here. For more information, refer
		/// to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usag
		/// -plans-and-rate-limits-in-the-sp-api)..
		/// </summary>
		public async Task<GetFeatureInventoryGetResponse> GetFeatureInventoryAsync(GetFeatureInventoryGetRequest request)
		    => await this.SendAsync<GetFeatureInventoryGetResponse>(request);

		/// <summary>
		/// Returns the number of items with the sellerSKU you specify that can have orders fulfilled using the specified
		/// eature. Note that if the sellerSKU isn't eligible, the response will contain an empty skuInfo object. The para
		/// eters for this operation may contain special characters that require URL encoding. To avoid errors with SKUs w
		/// en encoding URLs, refer to [URL Encoding](https://developer-docs.amazon.com/sp-api/docs/url-encoding).  **Usag
		/// Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 30 |  The `x-amzn-RateLimit-Limit` resp
		/// nse header returns the usage plan rate limits that were applied to the requested operation, when available. Th
		/// table above indicates the default rate and burst values for this operation. Selling partners whose business d
		/// mands require higher throughput may have higher rate and burst values than those shown here. For more informat
		/// on, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api
		/// docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetFeatureSKUGetResponse> GetFeatureSKUAsync(GetFeatureSKUGetRequest request)
		    => await this.SendAsync<GetFeatureSKUGetResponse>(request);
	}
}
