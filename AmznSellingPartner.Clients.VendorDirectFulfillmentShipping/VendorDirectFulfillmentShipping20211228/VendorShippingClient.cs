namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using System;
	using System.Threading.Tasks;

	public class VendorShippingClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Submits one or more shipment confirmations for vendor orders.  **Usage Plan:**  | Rate (requests per second) |
		/// Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate
		/// imits that were applied to the requested operation, when available. The preceding table indicates the default
		/// ate and burst values for this operation. Selling partners whose business demands require higher throughput may
		/// have higher rate and burst values then those shown here. For more information, refer to [Usage Plans and Rate
		/// imits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits).
		/// </summary>
		public async Task<SubmitShipmentConfirmationsPostResponse> SubmitShipmentConfirmationsAsync(SubmitShipmentConfirmationsPostRequest request)
		    => await this.SendAsync<SubmitShipmentConfirmationsPostResponse>(request);

		/// <summary>
		/// This operation is only to be used by Vendor-Own-Carrier (VOC) vendors. Calling this API submits a shipment sta
		/// us update for the package that a vendor has shipped. It will provide the Amazon customer visibility on their o
		/// der, when the package is outside of Amazon Network visibility.  **Usage Plan:**  | Rate (requests per second)
		/// Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate
		/// limits that were applied to the requested operation, when available. The preceding table indicates the default
		/// rate and burst values for this operation. Selling partners whose business demands require higher throughput ma
		/// have higher rate and burst values then those shown here. For more information, refer to [Usage Plans and Rate
		/// Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits).
		/// </summary>
		public async Task<SubmitShipmentStatusUpdatesPostResponse> SubmitShipmentStatusUpdatesAsync(SubmitShipmentStatusUpdatesPostRequest request)
		    => await this.SendAsync<SubmitShipmentStatusUpdatesPostResponse>(request);

		/// <summary>
		/// Returns a list of packing slips for the purchase orders that match the criteria specified. Date range to searc
		/// must not be more than 7 days.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 10 |
		/// 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the
		/// requested operation, when available. The preceding table indicates the default rate and burst values for this
		/// peration. Selling partners whose business demands require higher throughput may have higher rate and burst val
		/// es then those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner A
		/// I](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits).
		/// </summary>
		public async Task<GetPackingSlipsGetResponse> GetPackingSlipsAsync(GetPackingSlipsGetRequest request)
		    => await this.SendAsync<GetPackingSlipsGetResponse>(request);

		/// <summary>
		/// Returns a packing slip based on the purchaseOrderNumber that you specify.  **Usage Plan:**  | Rate (requests p
		/// r second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usag
		/// plan rate limits that were applied to the requested operation, when available. The preceding table indicates
		/// he default rate and burst values for this operation. Selling partners whose business demands require higher th
		/// oughput may have higher rate and burst values then those shown here. For more information, refer to [Usage Pla
		/// s and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-ra
		/// e-limits).
		/// </summary>
		public async Task<GetPackingSlipGetResponse> GetPackingSlipAsync(GetPackingSlipGetRequest request)
		    => await this.SendAsync<GetPackingSlipGetResponse>(request);
	}
}
