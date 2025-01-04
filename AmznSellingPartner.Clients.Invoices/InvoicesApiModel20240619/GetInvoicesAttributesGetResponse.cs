namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetInvoicesAttributesGetResponse : BaseHttpResponse<GetInvoicesAttributesGetResponse>
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
		public GetInvoicesAttributesResponse GetInvoicesAttributesResponse { get; set; }

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public ErrorList ErrorList { get; set; }
	}
}
