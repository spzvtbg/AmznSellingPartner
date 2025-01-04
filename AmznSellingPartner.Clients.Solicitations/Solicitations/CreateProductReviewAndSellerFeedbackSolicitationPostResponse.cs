namespace AmznSellingPartner.Clients.Solicitations.Solicitations
{
	using AmznSellingPartner.Clients.Attributes;

	public class CreateProductReviewAndSellerFeedbackSolicitationPostResponse : BaseHttpResponse
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. _Note:_ For this status code, the rate limit
		/// header is deprecated and no longer returned.
		/// </summary>
		[FromHeader("x-amzn-RateLimit-Limit")]
		public string XAmznRateLimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[FromHeader("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; } 

		/// <summary>
		/// The message was created for the order.
		/// </summary>
		public CreateProductReviewAndSellerFeedbackSolicitationResponse CreateProductReviewAndSellerFeedbackSolicitationResponse { get; set; } 
	}
}
