namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The HTTP status line associated with the response for an individual request within a batch. For more informati
	/// n, refer to [RFC 2616](https://www.w3.org/Protocols/rfc2616/rfc2616-sec6.html).
	/// </summary>
	public class HttpStatusLine : BaseClass
	{
		/// <summary>
		/// The HTTP response status code.
		/// </summary>
		[Minimum(100)]
		[Maximum(599)]
		[JsonProperty("statusCode")]
		public int StatusCode { get; set; }

		/// <summary>
		/// The HTTP response reason phrase.
		/// </summary>
		[JsonProperty("reasonPhrase")]
		public string ReasonPhrase { get; set; }
	}
}
