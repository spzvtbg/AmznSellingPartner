namespace AmznSellingPartner.Clients.Sellers.Sellers
{
	using System;
	using System.Threading.Tasks;

	public class SellersClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns a list of marketplaces that the seller submitting the request can sell in and information about the se
		/// ler's participation in those marketplaces
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 0
		/// 016 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// o the requested operation, when available
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values than t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetMarketplaceParticipationsGetResponse> GetMarketplaceParticipationsAsync(GetMarketplaceParticipationsGetRequest request)
		    => await this.SendAsync<GetMarketplaceParticipationsGetResponse>(request);

		/// <summary>
		/// Returns information about a seller account and its marketplaces
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 0
		/// 016 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// o the requested operation, when available
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values than t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetAccountGetResponse> GetAccountAsync(GetAccountGetRequest request)
		    => await this.SendAsync<GetAccountGetResponse>(request);
	}
}
