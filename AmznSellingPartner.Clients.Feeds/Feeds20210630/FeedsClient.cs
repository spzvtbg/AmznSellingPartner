namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using System;
	using System.Threading.Tasks;

	public class FeedsClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns feed details for the feeds that match the filters that you specify
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 0
		/// 0222 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// to the requested operation, when available
		/// The preceding table indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may have higher rate and burst values than
		/// hose shown here
		/// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-doc
		/// 
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetFeedsGetResponse> GetFeedsAsync(GetFeedsGetRequest request)
		    => await this.SendAsync<GetFeedsGetResponse>(request);

		/// <summary>
		/// Creates a feed
		/// Upload the contents of the feed document before calling this operation
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 0
		/// 0083 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// to the requested operation, when available
		/// The preceding table indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may have higher rate and burst values than
		/// hose shown here
		/// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-doc
		/// 
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// The rate limit for the [`JSON_LISTINGS_FEED`](https://developer-docs
		/// amazon
		/// com/sp-api/docs/listings-feed-type-values#listings-feed) feed type differs from the rate limit for the [`creat
		/// Feed`](https://developer-docs
		/// amazon
		/// com/sp-api/docs/feeds-api-v2021-06-30-reference#post-feeds2021-06-30feeds) operation
		/// For more information, refer to the [Building Listings Management Workflows Guide](https://developer-docs
		/// amazon
		/// com/sp-api/docs/building-listings-management-workflows-guide#should-i-submit-in-bulk-using-the-json_listings_f
		/// ed-or-individually-with-the-listings-items-api)
		/// </summary>
		public async Task<CreateFeedPostResponse> CreateFeedAsync(CreateFeedPostRequest request)
		    => await this.SendAsync<CreateFeedPostResponse>(request);

		/// <summary>
		/// Cancels the feed that you specify
		/// Only feeds with `processingStatus=IN_QUEUE` can be cancelled
		/// Cancelled feeds are returned in subsequent calls to the [`getFeed`](https://developer-docs
		/// amazon
		/// com/sp-api/docs/feeds-api-v2021-06-30-reference#getfeed) and [`getFeeds`](https://developer-docs
		/// amazon
		/// com/sp-api/docs/feeds-api-v2021-06-30-reference#getfeeds) operations
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 15 |  The `x-amzn-RateLimit-Li
		/// it` response header returns the usage plan rate limits that were applied to the requested operation, when avai
		/// able
		/// The preceding table indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may have higher rate and burst values than
		/// hose shown here
		/// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-doc
		/// 
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<CancelFeedDeleteResponse> CancelFeedAsync(CancelFeedDeleteRequest request)
		    => await this.SendAsync<CancelFeedDeleteResponse>(request);

		/// <summary>
		/// Returns feed details (including the `resultDocumentId`, if available) for the feed that you specify
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 15 |  The `x-amzn-RateLimit-Li
		/// it` response header returns the usage plan rate limits that were applied to the requested operation, when avai
		/// able
		/// The preceding table indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may have higher rate and burst values than
		/// hose shown here
		/// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-doc
		/// 
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetFeedGetResponse> GetFeedAsync(GetFeedGetRequest request)
		    => await this.SendAsync<GetFeedGetResponse>(request);

		/// <summary>
		/// Creates a feed document for the feed type that you specify
		/// This operation returns a presigned URL for uploading the feed document contents
		/// It also returns a `feedDocumentId` value that you can pass in with a subsequent call to the [`createFeed`](ht
		/// ps://developer-docs
		/// amazon
		/// com/sp-api/docs/feeds-api-v2021-06-30-reference#createfeed) operation
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 0
		/// 5 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to
		/// the requested operation, when available
		/// The preceding table indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may have higher rate and burst values than
		/// hose shown here
		/// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-doc
		/// 
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<CreateFeedDocumentPostResponse> CreateFeedDocumentAsync(CreateFeedDocumentPostRequest request)
		    => await this.SendAsync<CreateFeedDocumentPostResponse>(request);

		/// <summary>
		/// Returns the information required for retrieving a feed document's contents
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 0
		/// 0222 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// to the requested operation, when available
		/// The preceding table indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may have higher rate and burst values than
		/// hose shown here
		/// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-doc
		/// 
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetFeedDocumentGetResponse> GetFeedDocumentAsync(GetFeedDocumentGetRequest request)
		    => await this.SendAsync<GetFeedDocumentGetResponse>(request);
	}
}
