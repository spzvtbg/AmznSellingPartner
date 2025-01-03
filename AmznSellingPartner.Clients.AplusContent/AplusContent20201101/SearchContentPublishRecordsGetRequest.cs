namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/aplus/2020-11-01/contentPublishRecords")]
	public class SearchContentPublishRecordsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the marketplace where the A+ Content is published.
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		[MinLength(1)]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// The Amazon Standard Identification Number (ASIN).
		/// </summary>
		[InQuery("asin")]
		[IsRequired]
		[MinLength(10)]
		[JsonProperty("asin")]
		public string Asin { get; set; }

		/// <summary>
		/// A page token from the nextPageToken response element returned by your previous call to this operation. nextPag
		/// Token is returned when the results of a call exceed the page size. To get the next page of results, call the o
		/// eration and include pageToken as the only parameter. Specifying pageToken with any other parameter will cause
		/// he request to fail. When no nextPageToken value is returned there are no more pages to return. A pageToken val
		/// e is not usable across different operations.
		/// </summary>
		[InQuery("pageToken")]
		[MinLength(1)]
		[JsonProperty("pageToken")]
		public string PageToken { get; set; }
	}
}
