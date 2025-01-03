namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using System;
	using System.Threading.Tasks;

	public class OffersClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns aggregated replenishment program metrics for a selling partner's offers
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 1 |  The `x-amzn-RateLimit-Lim
		/// t` response header returns the usage plan rate limits that were applied to the requested operation, when avail
		/// ble
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values than t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<ListOfferMetricsPostResponse> ListOfferMetricsAsync(ListOfferMetricsPostRequest request)
		    => await this.SendAsync<ListOfferMetricsPostResponse>(request);

		/// <summary>
		/// Returns the details of a selling partner's replenishment program offers
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 1 |  The `x-amzn-RateLimit-Lim
		/// t` response header returns the usage plan rate limits that were applied to the requested operation, when avail
		/// ble
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values than t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<ListOffersPostResponse> ListOffersAsync(ListOffersPostRequest request)
		    => await this.SendAsync<ListOffersPostResponse>(request);
	}
}
