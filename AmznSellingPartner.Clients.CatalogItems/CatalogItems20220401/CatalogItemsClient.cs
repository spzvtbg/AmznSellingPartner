namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using System;
	using System.Threading.Tasks;

	public class CatalogItemsClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Search for and return a list of Amazon catalog items and associated information either by identifier or by key
		/// ords
		/// **Usage Plans:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Li
		/// it` response header returns the usage plan rate limits that were applied to the requested operation, when avai
		/// able
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may observe higher rate and burst values th
		/// n those shown here
		/// For more information, refer to the [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-a
		/// d-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<SearchCatalogItemsGetResponse> SearchCatalogItemsAsync(SearchCatalogItemsGetRequest request)
		    => await this.SendAsync<SearchCatalogItemsGetResponse>(request);

		/// <summary>
		/// Retrieves details for an item in the Amazon catalog
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 2 |  The `x-amzn-RateLimit-Lim
		/// t` response header returns the usage plan rate limits that were applied to the requested operation, when avail
		/// ble
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may observe higher rate and burst values th
		/// n those shown here
		/// For more information, refer to the [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-a
		/// d-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetCatalogItemGetResponse> GetCatalogItemAsync(GetCatalogItemGetRequest request)
		    => await this.SendAsync<GetCatalogItemGetResponse>(request);
	}
}
