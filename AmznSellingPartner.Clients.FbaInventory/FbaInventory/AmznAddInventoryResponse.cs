namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class AmznAddInventoryResponse : BaseHttpResponse<AmznAddInventoryResponse>
	{
		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// OK Request has missing or invalid parameters and cannot be parsed. Indicates access to the
		/// resource is forbidden. Possible reasons include Access Denied, Unauthorized, Expired Token,
		/// Invalid Signature or Resource Not Found. The specified resource does not exist. The frequency
		/// of requests was greater than allowed. An unexpected condition occurred that prevented the server
		/// from fulfilling the request. Temporary overloading or maintenance of the server.
		/// </summary>
		[HttpStatus(200)]
		[HttpStatus(400)]
		[HttpStatus(403)]
		[HttpStatus(404)]
		[HttpStatus(429)]
		[HttpStatus(500)]
		[HttpStatus(503)]
		public AddInventoryResponse AddInventoryResponse { get; set; } 
	}
}
