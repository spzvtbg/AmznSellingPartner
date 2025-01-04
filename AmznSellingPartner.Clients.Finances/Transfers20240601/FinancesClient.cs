namespace AmznSellingPartner.Clients.Finances.Transfers20240601
{
	using System;
	using System.Threading.Tasks;

	public class FinancesClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Initiates an on-demand payout to the seller's default deposit method in Seller Central for the given
		/// `marketplaceId` and `accountType`, if eligible. You can only initiate one on-demand payout for each marketplace
		/// and account type within a 24-hour period.   **Usage Plan:**  | Rate (requests per second) | Burst | |
		/// ---- | ---- | | 0.017 | 2 |  The `x-amzn-RateLimit-Limit` response header contains the usage plan rate
		/// limits for the operation, when available. The preceding table contains the default rate and burst values
		/// for this operation. Selling partners whose business demands require higher throughput might have higher
		/// rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Li
		/// mits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<InitiatePayoutPostResponse> InitiatePayoutAsync(InitiatePayoutPostRequest request)
		    => await this.SendAsync<InitiatePayoutPostResponse>(request);

		/// <summary>
		/// Returns the list of payment methods for the seller, which can be filtered by method type.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | .5 | 30 |  The `x-amzn-RateLimit-Limit` response
		/// header contains the usage plan rate limits for the operation, when available. The preceding table contains
		/// the default rate and burst values for this operation. Selling partners whose business demands require
		/// higher throughput might have higher rate and burst values than those shown here. For more information,
		/// refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and
		/// -rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetPaymentMethodsGetResponse> GetPaymentMethodsAsync(GetPaymentMethodsGetRequest request)
		    => await this.SendAsync<GetPaymentMethodsGetResponse>(request);
	}
}
