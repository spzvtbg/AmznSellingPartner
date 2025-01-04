namespace AmznSellingPartner.Clients.Tokens.Tokens20210301
{
	using System;
	using System.Threading.Tasks;

	public class TokensClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Returns a Restricted Data Token (RDT) for one or more restricted resources that you specify. A restricted
		/// resource is the HTTP method and path from a restricted operation that returns Personally Identifiable
		/// Information (PII), plus a dataElements value that indicates the type of PII requested. See the Tokens
		/// API Use Case Guide for a list of restricted operations. Use the RDT returned here as the access token
		/// in subsequent calls to the corresponding restricted operations.  **Usage Plan:**  | Rate (requests per
		/// second) | Burst | | ---- | ---- | | 1 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the
		/// usage plan rate limits that were applied to the requested operation, when available. The table above
		/// indicates the default rate and burst values for this operation. Selling partners whose business demands
		/// require higher throughput may see higher rate and burst values than those shown here. For more information,
		/// see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-ap
		/// i/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateRestrictedDataTokenPostResponse> CreateRestrictedDataTokenAsync(CreateRestrictedDataTokenPostRequest request)
		    => await this.SendAsync<CreateRestrictedDataTokenPostResponse>(request);
	}
}
