namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using System;
	using System.Threading.Tasks;

	public class CatalogItemsClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Search for and return a list of Amazon catalog items and associated information either by identifier or by key
		/// ords.  **Usage Plans:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLim
		/// t-Limit` response header returns the usage plan rate limits that were applied to the requested operation, when
		/// available. The table above indicates the default rate and burst values for this operation. Selling partners wh
		/// se business demands require higher throughput may observe higher rate and burst values than those shown here.
		/// or more information, refer to the [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and
		/// rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<SearchCatalogItemsGetResponse> SearchCatalogItemsAsync(SearchCatalogItemsGetRequest request)
		    => await this.SendAsync<SearchCatalogItemsGetResponse>(request);

		/// <summary>
		/// Retrieves details for an item in the Amazon catalog.  **Usage Plan:**  | Rate (requests per second) | Burst |
		/// ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that
		/// were applied to the requested operation, when available. The table above indicates the default rate and burst
		/// alues for this operation. Selling partners whose business demands require higher throughput may observe higher
		/// rate and burst values than those shown here. For more information, refer to the [Usage Plans and Rate Limits i
		/// the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetCatalogItemGetResponse> GetCatalogItemAsync(GetCatalogItemGetRequest request)
		    => await this.SendAsync<GetCatalogItemGetResponse>(request);
	}
}
