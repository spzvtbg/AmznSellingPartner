namespace AmznSellingPartner.Clients.Solicitations.Solicitations
{
	using System;
	using System.Threading.Tasks;

	public class SolicitationsClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns a list of solicitation types that are available for an order that you specify
		/// A solicitation type is represented by an actions object, which contains a path and query parameter(s)
		/// You can use the path and parameter(s) to call an operation that sends a solicitation
		/// Currently only the productReviewAndSellerFeedbackSolicitation solicitation type is available
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Lim
		/// t` response header returns the usage plan rate limits that were applied to the requested operation, when avail
		/// ble
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values than t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetSolicitationActionsForOrderGetResponse> GetSolicitationActionsForOrderAsync(GetSolicitationActionsForOrderGetRequest request)
		    => await this.SendAsync<GetSolicitationActionsForOrderGetResponse>(request);

		/// <summary>
		/// Sends a solicitation to a buyer asking for seller feedback and a product review for the specified order
		/// Send only one productReviewAndSellerFeedback or free form proactive message per order
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Lim
		/// t` response header returns the usage plan rate limits that were applied to the requested operation, when avail
		/// ble
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values than t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<CreateProductReviewAndSellerFeedbackSolicitationPostResponse> CreateProductReviewAndSellerFeedbackSolicitationAsync(CreateProductReviewAndSellerFeedbackSolicitationPostRequest request)
		    => await this.SendAsync<CreateProductReviewAndSellerFeedbackSolicitationPostResponse>(request);
	}
}
