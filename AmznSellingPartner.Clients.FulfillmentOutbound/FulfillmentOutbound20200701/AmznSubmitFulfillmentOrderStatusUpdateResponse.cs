namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class AmznSubmitFulfillmentOrderStatusUpdateResponse : BaseHttpResponse<AmznSubmitFulfillmentOrderStatusUpdateResponse>
	{
		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// Success. Request has missing or invalid parameters and cannot be parsed. The request's Authorization
		/// header is not formatted correctly or does not contain a valid token. Indicates that access
		/// to the resource is forbidden. Possible reasons include Access Denied, Unauthorized, Expired
		/// Token, or Invalid Signature. The specified resource does not exist. The frequency of requests
		/// was greater than allowed. An unexpected condition occurred that prevented the server from fulfilling
		/// the request. Temporary overloading or maintenance of the server.
		/// </summary>
		[HttpStatus(200)]
		[HttpStatus(400)]
		[HttpStatus(401)]
		[HttpStatus(403)]
		[HttpStatus(404)]
		[HttpStatus(429)]
		[HttpStatus(500)]
		[HttpStatus(503)]
		public SubmitFulfillmentOrderStatusUpdateResponse SubmitFulfillmentOrderStatusUpdateResponse { get; set; } 
	}
}
