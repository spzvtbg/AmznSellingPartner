namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using System;
	using System.Threading.Tasks;

	public class ProductPricingClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns the set of responses that correspond to the batched list of up to 40 requests defined in the request b
		/// dy. The response for each successful (HTTP status code 200) request in the set includes the computed listing p
		/// ice at or below which a seller can expect to become the featured offer (before applicable promotions). This is
		/// called the featured offer expected price (FOEP). Featured offer is not guaranteed because competing offers mig
		/// t change. Other offers might be featured based on factors such as fulfillment capabilities to a specific custo
		/// er. The response to an unsuccessful request includes the available error text.  **Usage Plan:**  | Rate (reque
		/// ts per second) | Burst | | ---- | ---- | | 0.033 | 1 |  The `x-amzn-RateLimit-Limit` response header returns t
		/// e usage plan rate limits that are applied to the requested operation, when available. The preceding table cont
		/// ins the default rate and burst values for this operation. Selling partners whose business demands require high
		/// r throughput may receive higher rate and burst values than those shown here. For more information, refer to [U
		/// age Plans and Rate Limits](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp
		/// api) in the Selling Partner API.
		/// </summary>
		public async Task<GetFeaturedOfferExpectedPriceBatchPostResponse> GetFeaturedOfferExpectedPriceBatchAsync(GetFeaturedOfferExpectedPriceBatchPostRequest request)
		    => await this.SendAsync<GetFeaturedOfferExpectedPriceBatchPostResponse>(request);

		/// <summary>
		/// Returns the competitive summary response, including featured buying options for the ASIN and `marketplaceId` c
		/// mbination.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 0.033 | 1 |  The `x-amzn
		/// RateLimit-Limit` response header returns the usage plan rate limits that are applied to the requested operatio
		/// , when available. The preceding table contains the default rate and burst values for this operation. Selling p
		/// rtners whose business demands require higher throughput may receive higher rate and burst values than those sh
		/// wn here. For more information, refer to [Usage Plans and Rate Limits](https://developer-docs.amazon.com/sp-api
		/// docs/usage-plans-and-rate-limits-in-the-sp-api) in the Selling Partner API.
		/// </summary>
		public async Task<GetCompetitiveSummaryPostResponse> GetCompetitiveSummaryAsync(GetCompetitiveSummaryPostRequest request)
		    => await this.SendAsync<GetCompetitiveSummaryPostResponse>(request);
	}
}
