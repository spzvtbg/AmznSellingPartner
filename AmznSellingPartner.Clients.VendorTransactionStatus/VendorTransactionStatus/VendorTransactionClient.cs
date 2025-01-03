namespace AmznSellingPartner.Clients.VendorTransactionStatus.VendorTransactionStatus
{
	using System;
	using System.Threading.Tasks;

	public class VendorTransactionClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns the status of the transaction that you specify.  **Usage Plan:**  | Rate (requests per second) | Burst
		/// | | ---- | ---- | | 10 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
		/// that were applied to the requested operation, when available. The table above indicates the default rate and b
		/// rst values for this operation. Selling partners whose business demands require higher throughput may see highe
		/// rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the Se
		/// ling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetTransactionGetResponse> GetTransactionAsync(GetTransactionGetRequest request)
		    => await this.SendAsync<GetTransactionGetResponse>(request);
	}
}
