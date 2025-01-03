namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using System;
	using System.Threading.Tasks;

	public class OrdersClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns orders that are created or updated during the specified time period. If you want to return specific ty
		/// es of orders, you can apply filters to your request. `NextToken` doesn't affect any filters that you include i
		/// your request; it only impacts the pagination for the filtered orders response.   **Usage Plan:**  | Rate (req
		/// ests per second) | Burst | | ---- | ---- | | 0.0167 | 20 |  The `x-amzn-RateLimit-Limit` response header retur
		/// s the usage plan rate limits that are applied to the requested operation, when available. The preceding table
		/// ontains the default rate and burst values for this operation. Selling partners whose business demands require
		/// igher throughput may receive higher rate and burst values then those shown here. For more information, refer t
		/// [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-th
		/// -sp-api) in the Selling Partner API documentation.
		/// </summary>
		public async Task<GetOrdersGetResponse> GetOrdersAsync(GetOrdersGetRequest request)
		    => await this.SendAsync<GetOrdersGetResponse>(request);

		/// <summary>
		/// Returns the order that you specify.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | |
		/// 0.5 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// o the requested operation, when available. The preceding table contains the default rate and burst values for
		/// his operation. Selling partners whose business demands require higher throughput may receive higher rate and b
		/// rst values then those shown here. For more information, refer to [Usage Plans and Rate Limits](https://develop
		/// r-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetOrderGetResponse> GetOrderAsync(GetOrderGetRequest request)
		    => await this.SendAsync<GetOrderGetResponse>(request);

		/// <summary>
		/// Returns buyer information for the order that you specify.  **Usage Plan:**  | Rate (requests per second) | Bur
		/// t | | ---- | ---- | | 0.5 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate lim
		/// ts that were applied to the requested operation, when available. The preceding table contains the default rate
		/// and burst values for this operation. Selling partners whose business demands require higher throughput may rec
		/// ive higher rate and burst values then those shown here. For more information, refer to [Usage Plans and Rate L
		/// mits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetOrderBuyerInfoGetResponse> GetOrderBuyerInfoAsync(GetOrderBuyerInfoGetRequest request)
		    => await this.SendAsync<GetOrderBuyerInfoGetResponse>(request);

		/// <summary>
		/// Returns the shipping address for the order that you specify.  **Usage Plan:**  | Rate (requests per second) |
		/// urst | | ---- | ---- | | 0.5 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate
		/// imits that were applied to the requested operation, when available. The preceding table contains the default r
		/// te and burst values for this operation. Selling partners whose business demands require higher throughput may
		/// eceive higher rate and burst values then those shown here. For more information, refer to [Usage Plans and Rat
		/// Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetOrderAddressGetResponse> GetOrderAddressAsync(GetOrderAddressGetRequest request)
		    => await this.SendAsync<GetOrderAddressGetResponse>(request);

		/// <summary>
		/// Returns detailed order item information for the order that you specify. If `NextToken` is provided, it's used
		/// o retrieve the next page of order items.  __Note__: When an order is in the Pending state (the order has been
		/// laced but payment has not been authorized), the getOrderItems operation does not return information about pric
		/// ng, taxes, shipping charges, gift status or promotions for the order items in the order. After an order leaves
		/// the Pending state (this occurs when payment has been authorized) and enters the Unshipped, Partially Shipped,
		/// r Shipped state, the getOrderItems operation returns information about pricing, taxes, shipping charges, gift
		/// tatus and promotions for the order items in the order.  **Usage Plan:**  | Rate (requests per second) | Burst
		/// | ---- | ---- | | 0.5 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
		/// that were applied to the requested operation, when available. The preceding table contains the default rate an
		/// burst values for this operation. Selling partners whose business demands require higher throughput may receiv
		/// higher rate and burst values then those shown here. For more information, refer to [Usage Plans and Rate Limi
		/// s](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetOrderItemsGetResponse> GetOrderItemsAsync(GetOrderItemsGetRequest request)
		    => await this.SendAsync<GetOrderItemsGetResponse>(request);

		/// <summary>
		/// Returns buyer information for the order items in the order that you specify.  **Usage Plan:**  | Rate (request
		/// per second) | Burst | | ---- | ---- | | 0.5 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the
		/// sage plan rate limits that were applied to the requested operation, when available. The preceding table contai
		/// s the default rate and burst values for this operation. Selling partners whose business demands require higher
		/// throughput may receive higher rate and burst values then those shown here. For more information, refer to [Usa
		/// e Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-a
		/// i).
		/// </summary>
		public async Task<GetOrderItemsBuyerInfoGetResponse> GetOrderItemsBuyerInfoAsync(GetOrderItemsBuyerInfoGetRequest request)
		    => await this.SendAsync<GetOrderItemsBuyerInfoGetResponse>(request);

		/// <summary>
		/// Update the shipment status for an order that you specify.  **Usage Plan:**  | Rate (requests per second) | Bur
		/// t | | ---- | ---- | | 5 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limit
		/// that were applied to the requested operation, when available. The preceding table contains the default rate a
		/// d burst values for this operation. Selling partners whose business demands require higher throughput may recei
		/// e higher rate and burst values then those shown here. For more information, refer to [Usage Plans and Rate Lim
		/// ts](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<UpdateShipmentStatusPostResponse> UpdateShipmentStatusAsync(UpdateShipmentStatusPostRequest request)
		    => await this.SendAsync<UpdateShipmentStatusPostResponse>(request);

		/// <summary>
		/// Returns regulated information for the order that you specify.  **Usage Plan:**  | Rate (requests per second) |
		/// Burst | | ---- | ---- | | 0.5 | 30 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate
		/// limits that were applied to the requested operation, when available. The preceding table contains the default
		/// ate and burst values for this operation. Selling partners whose business demands require higher throughput may
		/// receive higher rate and burst values then those shown here. For more information, refer to [Usage Plans and Ra
		/// e Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetOrderRegulatedInfoGetResponse> GetOrderRegulatedInfoAsync(GetOrderRegulatedInfoGetRequest request)
		    => await this.SendAsync<GetOrderRegulatedInfoGetResponse>(request);

		/// <summary>
		/// Updates (approves or rejects) the verification status of an order containing regulated products.  **Usage Plan
		/// **  | Rate (requests per second) | Burst | | ---- | ---- | | 0.5 | 30 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available. The pr
		/// ceding table contains the default rate and burst values for this operation. Selling partners whose business de
		/// ands require higher throughput may receive higher rate and burst values then those shown here. For more inform
		/// tion, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rat
		/// -limits-in-the-sp-api).
		/// </summary>
		public async Task<UpdateVerificationStatusPatchResponse> UpdateVerificationStatusAsync(UpdateVerificationStatusPatchRequest request)
		    => await this.SendAsync<UpdateVerificationStatusPatchResponse>(request);

		/// <summary>
		/// Updates the shipment confirmation status for a specified order.  **Usage Plan:**  | Rate (requests per second)
		/// | Burst | | ---- | ---- | | 2 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate
		/// limits that were applied to the requested operation, when available. The preceding table contains the default
		/// ate and burst values for this operation. Selling partners whose business demands require higher throughput may
		/// receive higher rate and burst values then those shown here. For more information, refer to [Usage Plans and Ra
		/// e Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<ConfirmShipmentPostResponse> ConfirmShipmentAsync(ConfirmShipmentPostRequest request)
		    => await this.SendAsync<ConfirmShipmentPostResponse>(request);
	}
}
