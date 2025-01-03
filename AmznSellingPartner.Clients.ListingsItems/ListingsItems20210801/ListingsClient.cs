namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using System;
	using System.Threading.Tasks;

	public class ListingsClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Delete a listings item for a selling partner.  **Note:** The parameters associated with this operation may con
		/// ain special characters that must be encoded to successfully call the API. To avoid errors with SKUs when encod
		/// ng URLs, refer to [URL Encoding](https://developer-docs.amazon.com/sp-api/docs/url-encoding).  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 10 |  The `x-amzn-RateLimit-Limit` response head
		/// r returns the usage plan rate limits that were applied to the requested operation, when available. The table a
		/// ove indicates the default rate and burst values for this operation. Selling partners whose business demands re
		/// uire higher throughput may see higher rate and burst values than those shown here. For more information, see [
		/// sage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-pla
		/// s-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<DeleteListingsItemDeleteResponse> DeleteListingsItemAsync(DeleteListingsItemDeleteRequest request)
		    => await this.SendAsync<DeleteListingsItemDeleteResponse>(request);

		/// <summary>
		/// Returns details about a listings item for a selling partner.  **Note:** The parameters associated with this op
		/// ration may contain special characters that must be encoded to successfully call the API. To avoid errors with
		/// KUs when encoding URLs, refer to [URL Encoding](https://developer-docs.amazon.com/sp-api/docs/url-encoding).
		/// *Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 10 |  The `x-amzn-RateLimit-Limit
		/// response header returns the usage plan rate limits that were applied to the requested operation, when availab
		/// e. The table above indicates the default rate and burst values for this operation. Selling partners whose busi
		/// ess demands require higher throughput may see higher rate and burst values than those shown here. For more inf
		/// rmation, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api
		/// docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetListingsItemGetResponse> GetListingsItemAsync(GetListingsItemGetRequest request)
		    => await this.SendAsync<GetListingsItemGetResponse>(request);

		/// <summary>
		/// Partially update (patch) a listings item for a selling partner. Only top-level listings item attributes can be
		/// patched. Patching nested attributes is not supported.  **Usage Plan:**  | Rate (requests per second) | Burst |
		/// | ---- | ---- | | 5 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits tha
		/// were applied to the requested operation, when available. The preceding table indicates the default rate and b
		/// rst values for this operation. Selling partners whose business demands require higher throughput can receive h
		/// gher rate and burst values then those shown here. For more information, refer to [Usage Plans and Rate Limits]
		/// https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api) in the Selling Partne
		/// API documentation.
		/// </summary>
		public async Task<PatchListingsItemPatchResponse> PatchListingsItemAsync(PatchListingsItemPatchRequest request)
		    => await this.SendAsync<PatchListingsItemPatchResponse>(request);

		/// <summary>
		/// Creates or fully updates an existing listings item for a selling partner.  **Note:** This operation has a thro
		/// tling rate of one request per second when `mode` is `VALIDATION_PREVIEW`.  **Note:** The parameters associated
		/// with this operation may contain special characters that must be encoded to successfully call the API. To avoid
		/// errors with SKUs when encoding URLs, refer to [URL Encoding](https://developer-docs.amazon.com/sp-api/docs/url
		/// encoding).  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 10 |  The `x-amzn-Ra
		/// eLimit-Limit` response header returns the usage plan rate limits that were applied to the requested operation,
		/// when available. The table above indicates the default rate and burst values for this operation. Selling partne
		/// s whose business demands require higher throughput may see higher rate and burst values than those shown here.
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amaz
		/// n.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<PutListingsItemPutResponse> PutListingsItemAsync(PutListingsItemPutRequest request)
		    => await this.SendAsync<PutListingsItemPutResponse>(request);

		/// <summary>
		/// Search for and return a list of selling partner listings items and their respective details.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 5 |  The `x-amzn-RateLimit-Limit` response header
		/// returns the usage plan rate limits that are applied to the requested operation, when available. The preceding
		/// able contains the default rate and burst values for this operation. Selling partners whose business demands re
		/// uire higher throughput might have higher rate and burst values than those shown here. For more information, re
		/// er to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-
		/// n-the-sp-api).
		/// </summary>
		public async Task<SearchListingsItemsGetResponse> SearchListingsItemsAsync(SearchListingsItemsGetRequest request)
		    => await this.SendAsync<SearchListingsItemsGetResponse>(request);
	}
}
