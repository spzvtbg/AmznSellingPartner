namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using System;
	using System.Threading.Tasks;

	public class AmznMfnClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Returns a list of shipping service offers that satisfy the specified shipment request details.
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 6 | 12 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that are applied to the requested operation
		/// when available. The preceding table indicates the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput may have higher rate and
		/// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// in the SP-API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-i
		/// n-the-sp-api).
		/// </summary>
		public async Task<AmznGetEligibleShipmentServicesResponse> GetEligibleShipmentServicesAsync(AmznGetEligibleShipmentServicesRequest request)
		    => await SendAsync<AmznGetEligibleShipmentServicesResponse>(request);

		/// <summary>
		/// Cancel the shipment indicated by the specified shipment identifier.  **Usage Plan:**  | Rate
		/// (requests per second) | Burst | | ---- | ---- | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that are applied to the requested operation when
		/// available. The preceding table indicates the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput may have higher rate and
		/// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// in the SP-API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-i
		/// n-the-sp-api).
		/// </summary>
		public async Task<AmznCancelShipmentResponse> CancelShipmentAsync(AmznCancelShipmentRequest request)
		    => await SendAsync<AmznCancelShipmentResponse>(request);

		/// <summary>
		/// Returns the shipment information for an existing shipment.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header
		/// returns the usage plan rate limits that are applied to the requested operation when available.
		/// The preceding table indicates the default rate and burst values for this operation. Selling
		/// partners whose business demands require higher throughput may have higher rate and burst values
		/// than those shown here. For more information, refer to [Usage Plans and Rate Limits in the
		/// SP-API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-s
		/// p-api).
		/// </summary>
		public async Task<AmznGetShipmentResponse> GetShipmentAsync(AmznGetShipmentRequest request)
		    => await SendAsync<AmznGetShipmentResponse>(request);

		/// <summary>
		/// Create a shipment with the information provided.  **Usage Plan:**  | Rate (requests per second)
		/// | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the
		/// usage plan rate limits that are applied to the requested operation when available. The preceding
		/// table indicates the default rate and burst values for this operation. Selling partners whose
		/// business demands require higher throughput may have higher rate and burst values than those
		/// shown here. For more information, refer to [Usage Plans and Rate Limits in the SP-API](htt
		/// ps://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznCreateShipmentResponse> CreateShipmentAsync(AmznCreateShipmentRequest request)
		    => await SendAsync<AmznCreateShipmentResponse>(request);

		/// <summary>
		/// Gets a list of additional seller inputs required for a ship method. This is generally used
		/// for international shipping.  **Usage Plan:**  | Rate (requests per second) | Burst | | ----
		/// | ---- | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate
		/// limits that are applied to the requested operation when available. The preceding table indicates
		/// the default rate and burst values for this operation. Selling partners whose business demands
		/// require higher throughput may have higher rate and burst values than those shown here. For
		/// more information, refer to [Usage Plans and Rate Limits in the SP-API](https://developer-d
		/// ocs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznGetAdditionalSellerInputsResponse> GetAdditionalSellerInputsAsync(AmznGetAdditionalSellerInputsRequest request)
		    => await SendAsync<AmznGetAdditionalSellerInputsResponse>(request);
	}
}
