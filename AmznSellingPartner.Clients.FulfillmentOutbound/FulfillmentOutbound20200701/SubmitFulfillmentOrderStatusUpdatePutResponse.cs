namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	public class SubmitFulfillmentOrderStatusUpdatePutResponse : BaseHttpResponse<SubmitFulfillmentOrderStatusUpdatePutResponse>
	{
		[JsonProperty("Is200")]
		public bool Is200 { get; set; }

		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; }

		/// <summary>
		/// Success.
		/// </summary>
		[JsonProperty("Value200")]
		public SubmitFulfillmentOrderStatusUpdateResponse Value200 { get; set; }

		[JsonProperty("Is400")]
		public bool Is400 { get; set; }

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		[JsonProperty("Value400")]
		public SubmitFulfillmentOrderStatusUpdateResponse Value400 { get; set; }

		[JsonProperty("Is401")]
		public bool Is401 { get; set; }

		/// <summary>
		/// The request's Authorization header is not formatted correctly or does not contain a valid token.
		/// </summary>
		[JsonProperty("Value401")]
		public SubmitFulfillmentOrderStatusUpdateResponse Value401 { get; set; }

		[JsonProperty("Is403")]
		public bool Is403 { get; set; }

		/// <summary>
		/// Indicates that access to the resource is forbidden. Possible reasons include Access Denied, Unauthorized, Expi
		/// ed Token, or Invalid Signature.
		/// </summary>
		[JsonProperty("Value403")]
		public SubmitFulfillmentOrderStatusUpdateResponse Value403 { get; set; }

		[JsonProperty("Is404")]
		public bool Is404 { get; set; }

		/// <summary>
		/// The specified resource does not exist.
		/// </summary>
		[JsonProperty("Value404")]
		public SubmitFulfillmentOrderStatusUpdateResponse Value404 { get; set; }

		[JsonProperty("Is429")]
		public bool Is429 { get; set; }

		/// <summary>
		/// The frequency of requests was greater than allowed.
		/// </summary>
		[JsonProperty("Value429")]
		public SubmitFulfillmentOrderStatusUpdateResponse Value429 { get; set; }

		[JsonProperty("Is500")]
		public bool Is500 { get; set; }

		/// <summary>
		/// An unexpected condition occurred that prevented the server from fulfilling the request.
		/// </summary>
		[JsonProperty("Value500")]
		public SubmitFulfillmentOrderStatusUpdateResponse Value500 { get; set; }

		[JsonProperty("Is503")]
		public bool Is503 { get; set; }

		/// <summary>
		/// Temporary overloading or maintenance of the server.
		/// </summary>
		[JsonProperty("Value503")]
		public SubmitFulfillmentOrderStatusUpdateResponse Value503 { get; set; }
	}
}
