namespace AmznSellingPartner.Clients.FbaInboundEligibility.FbaInbound
{
	using System;
	using System.Threading.Tasks;

	public class FbaInboundClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// This operation gets an eligibility preview for an item that you specify. You can specify the type of
		/// eligibility preview that you want (INBOUND or COMMINGLING). For INBOUND previews, you can specify the
		/// marketplace in which you want to determine the item's eligibility.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response header returns
		/// the usage plan rate limits that were applied to the requested operation, when available. The table above
		/// indicates the default rate and burst values for this operation. Selling partners whose business demands
		/// require higher throughput may see higher rate and burst values than those shown here. For more information,
		/// see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-ap
		/// i/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetItemEligibilityPreviewGetResponse> GetItemEligibilityPreviewAsync(GetItemEligibilityPreviewGetRequest request)
		    => await this.SendAsync<GetItemEligibilityPreviewGetResponse>(request);
	}
}
