namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using System;
	using System.Threading.Tasks;

	public class AwdClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Retrieves an AWD inbound shipment.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- |
		/// ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that
		/// were applied to the requested operation, when available. The table above indicates the default rate and
		/// burst values for this operation. Selling partners whose business demands require higher throughput may
		/// see higher rate and burst values than those shown here. For more information, refer to [Usage Plans and
		/// Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-an
		/// d-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetInboundShipmentGetResponse> GetInboundShipmentAsync(GetInboundShipmentGetRequest request)
		    => await this.SendAsync<GetInboundShipmentGetResponse>(request);

		/// <summary>
		/// Retrieves a summary of all the inbound AWD shipments associated with a merchant, with the ability to
		/// apply optional filters.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1
		/// | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// to the requested operation, when available. The table above indicates the default rate and burst values
		/// for this operation. Selling partners whose business demands require higher throughput may see higher
		/// rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limit
		/// s-in-the-sp-api).
		/// </summary>
		public async Task<ListInboundShipmentsGetResponse> ListInboundShipmentsAsync(ListInboundShipmentsGetRequest request)
		    => await this.SendAsync<ListInboundShipmentsGetResponse>(request);

		/// <summary>
		/// Lists AWD inventory associated with a merchant with the ability to apply optional filters.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The table above indicates the default rate and burst values for this operation. Selling partners whose
		/// business demands require higher throughput may see higher rate and burst values than those shown here.
		/// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://deve
		/// loper-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<ListInventoryGetResponse> ListInventoryAsync(ListInventoryGetRequest request)
		    => await this.SendAsync<ListInventoryGetResponse>(request);
	}
}
