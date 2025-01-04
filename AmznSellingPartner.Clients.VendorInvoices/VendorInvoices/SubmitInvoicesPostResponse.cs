namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using AmznSellingPartner.Clients.Attributes;

	public class SubmitInvoicesPostResponse : BaseHttpResponse<SubmitInvoicesPostResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation.
		/// </summary>
		[FromHeader("x-amzn-RateLimit-Limit")]
		public string XAmznRateLimitLimit { get; set; }

		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[FromHeader("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; }

		public bool Succeeded { get; set; }

		/// <summary>
		/// Success.
		/// </summary>
		public SubmitInvoicesResponse SubmitInvoicesResponse { get; set; }
	}
}
