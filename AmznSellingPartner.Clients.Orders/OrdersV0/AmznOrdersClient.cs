namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using System;
	using System.Threading.Tasks;

	public class AmznOrdersClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Returns orders that are created or updated during the specified time period. If you want to
		/// return specific types of orders, you can apply filters to your request. `NextToken` doesn't
		/// affect any filters that you include in your request; it only impacts the pagination for the
		/// filtered orders response.   **Usage Plan:**  | Rate (requests per second) | Burst | | ----
		/// | ---- | | 0.0167 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan
		/// rate limits that are applied to the requested operation, when available. The preceding table
		/// contains the default rate and burst values for this operation. Selling partners whose business
		/// demands require higher throughput may receive higher rate and burst values then those shown
		/// here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// in the Selling Partner API documentation.
		/// </summary>
		public async Task<AmznGetOrdersResponse> GetOrdersAsync(AmznGetOrdersRequest request)
		    => await SendAsync<AmznGetOrdersResponse>(request);

		/// <summary>
		/// Returns the order that you specify.  **Usage Plan:**  | Rate (requests per second) | Burst
		/// | | ---- | ---- | | 0.5 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage
		/// plan rate limits that were applied to the requested operation, when available. The preceding
		/// table contains the default rate and burst values for this operation. Selling partners whose
		/// business demands require higher throughput may receive higher rate and burst values then those
		/// shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer
		/// -docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznGetOrderResponse> GetOrderAsync(AmznGetOrderRequest request)
		    => await SendAsync<AmznGetOrderResponse>(request);

		/// <summary>
		/// Returns buyer information for the order that you specify.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 0.5 | 30 |  The `x-amzn-RateLimit-Limit` response header
		/// returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The preceding table contains the default rate and burst values for this operation. Selling
		/// partners whose business demands require higher throughput may receive higher rate and burst
		/// values then those shown here. For more information, refer to [Usage Plans and Rate Limits]
		/// (https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznGetOrderBuyerInfoResponse> GetOrderBuyerInfoAsync(AmznGetOrderBuyerInfoRequest request)
		    => await SendAsync<AmznGetOrderBuyerInfoResponse>(request);

		/// <summary>
		/// Returns the shipping address for the order that you specify.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 0.5 | 30 |  The `x-amzn-RateLimit-Limit` response header
		/// returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The preceding table contains the default rate and burst values for this operation. Selling
		/// partners whose business demands require higher throughput may receive higher rate and burst
		/// values then those shown here. For more information, refer to [Usage Plans and Rate Limits]
		/// (https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznGetOrderAddressResponse> GetOrderAddressAsync(AmznGetOrderAddressRequest request)
		    => await SendAsync<AmznGetOrderAddressResponse>(request);

		/// <summary>
		/// Returns detailed order item information for the order that you specify. If `NextToken` is provided,
		/// it's used to retrieve the next page of order items.  __Note__: When an order is in the Pending
		/// state (the order has been placed but payment has not been authorized), the getOrderItems operation
		/// does not return information about pricing, taxes, shipping charges, gift status or promotions
		/// for the order items in the order. After an order leaves the Pending state (this occurs when
		/// payment has been authorized) and enters the Unshipped, Partially Shipped, or Shipped state,
		/// the getOrderItems operation returns information about pricing, taxes, shipping charges, gift
		/// status and promotions for the order items in the order.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 0.5 | 30 |  The `x-amzn-RateLimit-Limit` response header
		/// returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The preceding table contains the default rate and burst values for this operation. Selling
		/// partners whose business demands require higher throughput may receive higher rate and burst
		/// values then those shown here. For more information, refer to [Usage Plans and Rate Limits]
		/// (https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznGetOrderItemsResponse> GetOrderItemsAsync(AmznGetOrderItemsRequest request)
		    => await SendAsync<AmznGetOrderItemsResponse>(request);

		/// <summary>
		/// Returns buyer information for the order items in the order that you specify.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 0.5 | 30 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation,
		/// when available. The preceding table contains the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput may receive higher rate and
		/// burst values then those shown here. For more information, refer to [Usage Plans and Rate L
		/// imits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp
		/// -api).
		/// </summary>
		public async Task<AmznGetOrderItemsBuyerInfoResponse> GetOrderItemsBuyerInfoAsync(AmznGetOrderItemsBuyerInfoRequest request)
		    => await SendAsync<AmznGetOrderItemsBuyerInfoResponse>(request);

		/// <summary>
		/// Update the shipment status for an order that you specify.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 5 | 15 |  The `x-amzn-RateLimit-Limit` response header
		/// returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The preceding table contains the default rate and burst values for this operation. Selling
		/// partners whose business demands require higher throughput may receive higher rate and burst
		/// values then those shown here. For more information, refer to [Usage Plans and Rate Limits]
		/// (https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznUpdateShipmentStatusResponse> UpdateShipmentStatusAsync(AmznUpdateShipmentStatusRequest request)
		    => await SendAsync<AmznUpdateShipmentStatusResponse>(request);

		/// <summary>
		/// Returns regulated information for the order that you specify.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 0.5 | 30 |  The `x-amzn-RateLimit-Limit` response header
		/// returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The preceding table contains the default rate and burst values for this operation. Selling
		/// partners whose business demands require higher throughput may receive higher rate and burst
		/// values then those shown here. For more information, refer to [Usage Plans and Rate Limits]
		/// (https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznGetOrderRegulatedInfoResponse> GetOrderRegulatedInfoAsync(AmznGetOrderRegulatedInfoRequest request)
		    => await SendAsync<AmznGetOrderRegulatedInfoResponse>(request);

		/// <summary>
		/// Updates (approves or rejects) the verification status of an order containing regulated products.
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 0.5 | 30 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation,
		/// when available. The preceding table contains the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput may receive higher rate and
		/// burst values then those shown here. For more information, refer to [Usage Plans and Rate L
		/// imits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp
		/// -api).
		/// </summary>
		public async Task<AmznUpdateVerificationStatusResponse> UpdateVerificationStatusAsync(AmznUpdateVerificationStatusRequest request)
		    => await SendAsync<AmznUpdateVerificationStatusResponse>(request);

		/// <summary>
		/// Updates the shipment confirmation status for a specified order.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 2 | 10 |  The `x-amzn-RateLimit-Limit` response header
		/// returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The preceding table contains the default rate and burst values for this operation. Selling
		/// partners whose business demands require higher throughput may receive higher rate and burst
		/// values then those shown here. For more information, refer to [Usage Plans and Rate Limits]
		/// (https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznConfirmShipmentResponse> ConfirmShipmentAsync(AmznConfirmShipmentRequest request)
		    => await SendAsync<AmznConfirmShipmentResponse>(request);
	}
}
