namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using System;
	using System.Threading.Tasks;

	public class AmznListingsClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Delete a listings item for a selling partner.  **Note:** The parameters associated with this
		/// operation may contain special characters that must be encoded to successfully call the API.
		/// To avoid errors with SKUs when encoding URLs, refer to [URL Encoding](https://developer-docs.amazon.com/sp-api/docs/url-encoding).
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 10 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation,
		/// when available. The table above indicates the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput may see higher rate and burst
		/// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
		/// Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-li
		/// mits-in-the-sp-api).
		/// </summary>
		public async Task<AmznDeleteListingsItemResponse> DeleteListingsItemAsync(AmznDeleteListingsItemRequest request)
		    => await SendAsync<AmznDeleteListingsItemResponse>(request);

		/// <summary>
		/// Returns details about a listings item for a selling partner.  **Note:** The parameters associated
		/// with this operation may contain special characters that must be encoded to successfully call
		/// the API. To avoid errors with SKUs when encoding URLs, refer to [URL Encoding](https://developer-docs.amazon.com/sp-api/docs/url-encoding).
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 10 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation,
		/// when available. The table above indicates the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput may see higher rate and burst
		/// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
		/// Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-li
		/// mits-in-the-sp-api).
		/// </summary>
		public async Task<AmznGetListingsItemResponse> GetListingsItemAsync(AmznGetListingsItemRequest request)
		    => await SendAsync<AmznGetListingsItemResponse>(request);

		/// <summary>
		/// Partially update (patch) a listings item for a selling partner. Only top-level listings item
		/// attributes can be patched. Patching nested attributes is not supported.  **Usage Plan:**  |
		/// Rate (requests per second) | Burst | | ---- | ---- | | 5 | 5 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation,
		/// when available. The preceding table indicates the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput can receive higher rate and
		/// burst values then those shown here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// in the Selling Partner API documentation.
		/// </summary>
		public async Task<AmznPatchListingsItemResponse> PatchListingsItemAsync(AmznPatchListingsItemRequest request)
		    => await SendAsync<AmznPatchListingsItemResponse>(request);

		/// <summary>
		/// Creates or fully updates an existing listings item for a selling partner.  **Note:** This operation
		/// has a throttling rate of one request per second when `mode` is `VALIDATION_PREVIEW`.  **Note:**
		/// The parameters associated with this operation may contain special characters that must be encoded
		/// to successfully call the API. To avoid errors with SKUs when encoding URLs, refer to [URL Encoding](https://developer-docs.amazon.com/sp-api/docs/url-encoding).
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 10 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation,
		/// when available. The table above indicates the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput may see higher rate and burst
		/// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
		/// Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-li
		/// mits-in-the-sp-api).
		/// </summary>
		public async Task<AmznPutListingsItemResponse> PutListingsItemAsync(AmznPutListingsItemRequest request)
		    => await SendAsync<AmznPutListingsItemResponse>(request);

		/// <summary>
		/// Search for and return a list of selling partner listings items and their respective details.
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 5 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that are applied to the requested operation,
		/// when available. The preceding table contains the default rate and burst values for this operation.
		/// Selling partners whose business demands require higher throughput might have higher rate and
		/// burst values than those shown here. For more information, refer to [Usage Plans and Rate L
		/// imits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp
		/// -api).
		/// </summary>
		public async Task<AmznSearchListingsItemsResponse> SearchListingsItemsAsync(AmznSearchListingsItemsRequest request)
		    => await SendAsync<AmznSearchListingsItemsResponse>(request);
	}
}
