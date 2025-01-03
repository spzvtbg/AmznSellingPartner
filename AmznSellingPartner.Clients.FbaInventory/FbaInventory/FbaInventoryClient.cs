namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using System;
	using System.Threading.Tasks;

	public class FbaInventoryClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns a list of inventory summaries. The summaries returned depend on the presence or absence of the startDa
		/// eTime, sellerSkus and sellerSku parameters:  - All inventory summaries with available details are returned whe
		/// the startDateTime, sellerSkus and sellerSku parameters are omitted. - When startDateTime is provided, the ope
		/// ation returns inventory summaries that have had changes after the date and time specified. The sellerSkus and
		/// ellerSku parameters are ignored. Important: To avoid errors, use both startDateTime and nextToken to get the n
		/// xt page of inventory summaries that have changed after the date and time specified. - When the sellerSkus para
		/// eter is provided, the operation returns inventory summaries for only the specified sellerSkus. The sellerSku p
		/// rameter is ignored. - When the sellerSku parameter is provided, the operation returns inventory summaries for
		/// nly the specified sellerSku.  Note: The parameters associated with this operation may contain special characte
		/// s that must be encoded to successfully call the API. To avoid errors with SKUs when encoding URLs, refer to [U
		/// L Encoding](https://developer-docs.amazon.com/sp-api/docs/url-encoding).  Usage Plan:  | Rate (requests per se
		/// ond) | Burst | | ---- | ---- | | 2 | 2 |  The x-amzn-RateLimit-Limit response header returns the usage plan ra
		/// e limits that were applied to the requested operation, when available. The table above indicates the default r
		/// te and burst values for this operation. Selling partners whose business demands require higher throughput may
		/// ee higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits
		/// n the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits).
		/// </summary>
		public async Task<GetInventorySummariesGetResponse> GetInventorySummariesAsync(GetInventorySummariesGetRequest request)
		    => await this.SendAsync<GetInventorySummariesGetResponse>(request);

		/// <summary>
		/// Requests that Amazon create product-details in the Sandbox Inventory in the sandbox environment. This is a san
		/// box-only operation and must be directed to a sandbox endpoint. Refer to [Selling Partner API sandbox](https://
		/// eveloper-docs.amazon.com/sp-api/docs/the-selling-partner-api-sandbox) for more information.
		/// </summary>
		public async Task<CreateInventoryItemPostResponse> CreateInventoryItemAsync(CreateInventoryItemPostRequest request)
		    => await this.SendAsync<CreateInventoryItemPostResponse>(request);

		/// <summary>
		/// Requests that Amazon Deletes an item from the Sandbox Inventory in the sandbox environment. This is a sandbox-
		/// nly operation and must be directed to a sandbox endpoint. Refer to [Selling Partner API sandbox](https://devel
		/// per-docs.amazon.com/sp-api/docs/the-selling-partner-api-sandbox) for more information.
		/// </summary>
		public async Task<DeleteInventoryItemDeleteResponse> DeleteInventoryItemAsync(DeleteInventoryItemDeleteRequest request)
		    => await this.SendAsync<DeleteInventoryItemDeleteResponse>(request);

		/// <summary>
		/// Requests that Amazon add items to the Sandbox Inventory with desired amount of quantity in the sandbox environ
		/// ent. This is a sandbox-only operation and must be directed to a sandbox endpoint. Refer to [Selling Partner AP
		/// sandbox](https://developer-docs.amazon.com/sp-api/docs/the-selling-partner-api-sandbox) for more information.
		/// </summary>
		public async Task<AddInventoryPostResponse> AddInventoryAsync(AddInventoryPostRequest request)
		    => await this.SendAsync<AddInventoryPostResponse>(request);
	}
}
