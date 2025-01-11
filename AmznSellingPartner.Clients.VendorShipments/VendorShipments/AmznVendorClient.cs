namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using System;
	using System.Threading.Tasks;

	public class AmznVendorClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Submits one or more shipment confirmations for vendor orders.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header
		/// returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The table above indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may see higher rate and burst values than
		/// those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
		/// API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-a
		/// pi).
		/// </summary>
		public async Task<AmznSubmitShipmentConfirmationsResponse> SubmitShipmentConfirmationsAsync(AmznSubmitShipmentConfirmationsRequest request)
		    => await SendAsync<AmznSubmitShipmentConfirmationsResponse>(request);

		/// <summary>
		/// Returns the Details about Shipment, Carrier Details,  status of the shipment, container details
		/// and other details related to shipment based on the filter parameters value that you specify.
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation,
		/// when available. The table above indicates the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput may see higher rate and burst
		/// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
		/// Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-li
		/// mits-in-the-sp-api).
		/// </summary>
		public async Task<AmznGetShipmentDetailsResponse> GetShipmentDetailsAsync(AmznGetShipmentDetailsRequest request)
		    => await SendAsync<AmznGetShipmentDetailsResponse>(request);

		/// <summary>
		/// Submits one or more shipment request for vendor Orders.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header
		/// returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The table above indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may see higher rate and burst values than
		/// those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
		/// API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-a
		/// pi).
		/// </summary>
		public async Task<AmznSubmitShipmentsResponse> SubmitShipmentsAsync(AmznSubmitShipmentsRequest request)
		    => await SendAsync<AmznSubmitShipmentsResponse>(request);

		/// <summary>
		/// Returns small parcel shipment labels based on the filters that you specify.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit`
		/// response header contains the usage plan rate limits for the operation, when available. The
		/// preceding table contains the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput might have higher rate and burst values than
		/// those shown here. For more information, refer to [Usage Plans and Rate Limits](https://dev
		/// eloper-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznGetShipmentLabelsResponse> GetShipmentLabelsAsync(AmznGetShipmentLabelsRequest request)
		    => await SendAsync<AmznGetShipmentLabelsResponse>(request);
	}
}
