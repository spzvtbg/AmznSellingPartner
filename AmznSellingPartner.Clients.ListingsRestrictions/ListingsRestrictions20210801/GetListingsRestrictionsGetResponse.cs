namespace AmznSellingPartner.Clients.ListingsRestrictions.ListingsRestrictions20210801
{
	using Newtonsoft.Json;

	public class GetListingsRestrictionsGetResponse : BaseHttpResponse<GetListingsRestrictionsGetResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation.
		/// </summary>
		[JsonProperty("x-amzn-ratelimit-limit")]
		public string XAmznRatelimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// Successfully retrieved the listings restrictions.
		/// </summary>
		public RestrictionList RestrictionList { get; set; } 

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public ErrorList ErrorList { get; set; } 
	}
}
