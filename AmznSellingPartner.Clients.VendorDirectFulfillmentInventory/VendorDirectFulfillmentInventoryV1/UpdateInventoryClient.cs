namespace AmznSellingPartner.Clients.VendorDirectFulfillmentInventory.VendorDirectFulfillmentInventoryV1
{
	using System;
	using System.Threading.Tasks;

	public class UpdateInventoryClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Submits inventory updates for the specified warehouse for either a partial or full feed of inventory
		/// items.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation, when
		/// available. The table above indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may see higher rate and burst values than those shown
		/// here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://dev
		/// eloper-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<SubmitInventoryUpdatePostResponse> SubmitInventoryUpdateAsync(SubmitInventoryUpdatePostRequest request)
		    => await this.SendAsync<SubmitInventoryUpdatePostResponse>(request);
	}
}
