namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class AmznAddAppointmentForServiceJobByServiceJobIdResponse : BaseHttpResponse<AmznAddAppointmentForServiceJobByServiceJobIdResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. **Note:** For this status code, the
		/// rate limit header is deprecated and no longer returned.
		/// </summary>
		[JsonProperty("x-amzn-ratelimit-limit")]
		public string XAmznRatelimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// Success response. Request has missing or invalid parameters and cannot be parsed. Indicates
		/// that access to the resource is forbidden. Possible reasons include Access Denied, Unauthorized,
		/// Expired Token, or Invalid Signature. The resource specified does not exist. The request size
		/// exceeded the maximum accepted size. The request payload is in an unsupported format. Unprocessable
		/// Entity. Unable to process the contained instructions. The frequency of requests was greater
		/// than allowed. Encountered an unexpected condition which prevented the server from fulfilling
		/// the request. Temporary overloading or maintenance of the server.
		/// </summary>
		[HttpStatus(200)]
		[HttpStatus(400)]
		[HttpStatus(403)]
		[HttpStatus(404)]
		[HttpStatus(413)]
		[HttpStatus(415)]
		[HttpStatus(422)]
		[HttpStatus(429)]
		[HttpStatus(500)]
		[HttpStatus(503)]
		public SetAppointmentResponse SetAppointmentResponse { get; set; } 
	}
}
