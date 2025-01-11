namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using System;
	using System.Threading.Tasks;

	public class AmznCatalogClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Search for and return a list of Amazon catalog items and associated information either by identifier
		/// or by keywords.  **Usage Plans:**  | Rate (requests per second) | Burst | | ---- | ---- | |
		/// 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that
		/// were applied to the requested operation, when available. The table above indicates the default
		/// rate and burst values for this operation. Selling partners whose business demands require higher
		/// throughput may observe higher rate and burst values than those shown here. For more information,
		/// refer to the [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-
		/// rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznSearchCatalogItemsResponse> SearchCatalogItemsAsync(AmznSearchCatalogItemsRequest request)
		    => await SendAsync<AmznSearchCatalogItemsResponse>(request);

		/// <summary>
		/// Retrieves details for an item in the Amazon catalog.  **Usage Plan:**  | Rate (requests per
		/// second) | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Limit` response header returns
		/// the usage plan rate limits that were applied to the requested operation, when available. The
		/// table above indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may observe higher rate and burst values than
		/// those shown here. For more information, refer to the [Usage Plans and Rate Limits in the Selling
		/// Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AmznGetCatalogItemResponse> GetCatalogItemAsync(AmznGetCatalogItemRequest request)
		    => await SendAsync<AmznGetCatalogItemResponse>(request);
	}
}
