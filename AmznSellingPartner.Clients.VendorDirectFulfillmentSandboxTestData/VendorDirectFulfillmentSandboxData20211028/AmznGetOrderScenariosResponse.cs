namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class AmznGetOrderScenariosResponse : BaseHttpResponse<AmznGetOrderScenariosResponse>
	{
		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// Success.
		/// </summary>
		[HttpStatus(200)]
		public TransactionStatus TransactionStatus { get; set; } 

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed. The request's Authorization
		/// header is not formatted correctly or does not contain a valid token. Indicates that access
		/// to the resource is forbidden. Possible reasons include Access Denied, Unauthorized, Expired
		/// Token, or Invalid Signature. The resource specified does not exist. The request payload is
		/// in an unsupported format. The frequency of requests was greater than allowed. An unexpected
		/// condition occurred that prevented the server from fulfilling the request. Temporary overloading
		/// or maintenance of the server.
		/// </summary>
		[HttpStatus(400)]
		[HttpStatus(401)]
		[HttpStatus(403)]
		[HttpStatus(404)]
		[HttpStatus(415)]
		[HttpStatus(429)]
		[HttpStatus(500)]
		[HttpStatus(503)]
		public ErrorList ErrorList { get; set; } 
	}
}
