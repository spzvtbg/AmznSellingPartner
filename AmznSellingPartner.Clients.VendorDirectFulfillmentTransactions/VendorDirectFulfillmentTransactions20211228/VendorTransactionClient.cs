namespace AmznSellingPartner.Clients.VendorDirectFulfillmentTransactions.VendorDirectFulfillmentTransactions20211228
{
	using System;
	using System.Threading.Tasks;

	public class VendorTransactionClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns the status of the transaction indicated by the specified transactionId.  **Usage Plan:**  | Rate (requ
		/// sts per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns th
		/// usage plan rate limits that were applied to the requested operation, when available. The table above indicate
		/// the default rate and burst values for this operation. Selling partners whose business demands require higher
		/// hroughput may see higher rate and burst values then those shown here. For more information, see [Usage Plans a
		/// d Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetTransactionStatusGetResponse> GetTransactionStatusAsync(GetTransactionStatusGetRequest request)
		    => await this.SendAsync<GetTransactionStatusGetResponse>(request);
	}
}
