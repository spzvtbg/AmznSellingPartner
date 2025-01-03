namespace AmznSellingPartner.Clients.ListingsRestrictions.ListingsRestrictions20210801
{
	using System;
	using System.Threading.Tasks;

	public class ListingsClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns listing restrictions for an item in the Amazon Catalog
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 10 |  The `x-amzn-RateLimit-L
		/// mit` response header returns the usage plan rate limits that were applied to the requested operation, when ava
		/// lable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-l
		/// mits-in-the-sp-api)
		/// </summary>
		public async Task<GetListingsRestrictionsGetResponse> GetListingsRestrictionsAsync(GetListingsRestrictionsGetRequest request)
		    => await this.SendAsync<GetListingsRestrictionsGetResponse>(request);
	}
}
