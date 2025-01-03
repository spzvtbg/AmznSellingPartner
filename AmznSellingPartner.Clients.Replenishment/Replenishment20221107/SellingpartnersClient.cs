namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using System;
	using System.Threading.Tasks;

	public class SellingpartnersClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns aggregated replenishment program metrics for a selling partner.   **Usage Plan:**  | Rate (requests pe
		/// second) | Burst | | ---- | ---- | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage p
		/// an rate limits that were applied to the requested operation, when available. The table above indicates the def
		/// ult rate and burst values for this operation. Selling partners whose business demands require higher throughpu
		/// may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate L
		/// mits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
		/// he-sp-api).
		/// </summary>
		public async Task<GetSellingPartnerMetricsPostResponse> GetSellingPartnerMetricsAsync(GetSellingPartnerMetricsPostRequest request)
		    => await this.SendAsync<GetSellingPartnerMetricsPostResponse>(request);
	}
}
