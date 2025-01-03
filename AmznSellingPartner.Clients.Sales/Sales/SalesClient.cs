namespace AmznSellingPartner.Clients.Sales.Sales
{
	using System;
	using System.Threading.Tasks;

	public class SalesClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns aggregated order metrics for given interval, broken down by granularity, for given buyer type
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | |
		/// 5 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to
		/// the requested operation, when available
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values than t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-l
		/// mits-in-the-sp-api)
		/// </summary>
		public async Task<GetOrderMetricsGetResponse> GetOrderMetricsAsync(GetOrderMetricsGetRequest request)
		    => await this.SendAsync<GetOrderMetricsGetResponse>(request);
	}
}
