namespace AmznSellingPartner.Clients.Solicitations.Solicitations
{
	using Newtonsoft.Json;

	public class CreateProductReviewAndSellerFeedbackSolicitationPostResponse : BaseHttpResponse<CreateProductReviewAndSellerFeedbackSolicitationPostResponse>
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
		/// The message was created for the order.
		/// </summary>
		public CreateProductReviewAndSellerFeedbackSolicitationResponse CreateProductReviewAndSellerFeedbackSolicitationResponse { get; set; } 
	}
}
