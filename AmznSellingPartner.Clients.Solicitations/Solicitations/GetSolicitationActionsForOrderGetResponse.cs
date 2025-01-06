namespace AmznSellingPartner.Clients.Solicitations.Solicitations
{
	using Newtonsoft.Json;

	public class GetSolicitationActionsForOrderGetResponse : BaseHttpResponse<GetSolicitationActionsForOrderGetResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. _Note:_ For this status code, the rate limit
		/// header is deprecated and no longer returned.
		/// </summary>
		[JsonProperty("x-amzn-ratelimit-limit")]
		public string XAmznRatelimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// Returns hypermedia links under the _links.actions key that specify which solicitation actions are allowed
		/// for the order.
		/// </summary>
		public GetSolicitationActionsForOrderResponse GetSolicitationActionsForOrderResponse { get; set; } 
	}
}
