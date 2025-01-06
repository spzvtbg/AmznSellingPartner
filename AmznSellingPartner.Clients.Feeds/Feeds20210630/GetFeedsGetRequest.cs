namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpGet("/feeds/2021-06-30/feeds")]
	public class GetFeedsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// A list of feed types used to filter feeds. When feedTypes is provided, the other filter parameters (processingStatuses,
		/// marketplaceIds, createdSince, createdUntil) and pageSize may also be provided. Either feedTypes or nextToken
		/// is required.
		/// </summary>
		[InQuery("feedTypes")]
		[MinItems(1)]
		[MaxItems(10)]
		public CsvValue<string> FeedTypes { get; set; } 

		/// <summary>
		/// A list of marketplace identifiers used to filter feeds. The feeds returned will match at least one of
		/// the marketplaces that you specify.
		/// </summary>
		[InQuery("marketplaceIds")]
		[MinItems(1)]
		[MaxItems(10)]
		public CsvValue<string> MarketplaceIds { get; set; } 

		/// <summary>
		/// The maximum number of feeds to return in a single call.
		/// </summary>
		[InQuery("pageSize")]
		[Minimum(1)]
		[Maximum(100)]
		public int PageSize { get; set; } = 10;

		/// <summary>
		/// A list of processing statuses used to filter feeds.
		/// </summary>
		[InQuery("processingStatuses")]
		[MinItems(1)]
		public CsvValue<ProcessingStatuses> ProcessingStatuses { get; set; } 

		/// <summary>
		/// The earliest feed creation date and time for feeds included in the response, in ISO 8601 format. The
		/// default is 90 days ago. Feeds are retained for a maximum of 90 days.
		/// </summary>
		[InQuery("createdSince")]
		public DateTimeValue CreatedSince { get; set; } 

		/// <summary>
		/// The latest feed creation date and time for feeds included in the response, in ISO 8601 format. The default
		/// is now.
		/// </summary>
		[InQuery("createdUntil")]
		public DateTimeValue CreatedUntil { get; set; } 

		/// <summary>
		/// A string token returned in the response to your previous request. nextToken is returned when the number
		/// of results exceeds the specified pageSize value. To get the next page of results, call the getFeeds operation
		/// and include this token as the only parameter. Specifying nextToken with any other parameters will cause
		/// the request to fail.
		/// </summary>
		[InQuery("nextToken")]
		public string NextToken { get; set; } 
	}
}
