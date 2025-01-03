namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using Newtonsoft.Json;

	public class DeleteInventoryItemDeleteResponse : BaseHttpResponse<DeleteInventoryItemDeleteResponse>
	{
		[JsonProperty("Is200")]
		public bool Is200 { get; set; }

		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; }

		/// <summary>
		/// OK
		/// </summary>
		[JsonProperty("Value200")]
		public DeleteInventoryItemResponse Value200 { get; set; }

		[JsonProperty("Is400")]
		public bool Is400 { get; set; }

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		[JsonProperty("Value400")]
		public DeleteInventoryItemResponse Value400 { get; set; }

		[JsonProperty("Is403")]
		public bool Is403 { get; set; }

		/// <summary>
		/// Indicates access to the resource is forbidden. Possible reasons include Access Denied, Unauthorized, Expired T
		/// ken, Invalid Signature or Resource Not Found.
		/// </summary>
		[JsonProperty("Value403")]
		public DeleteInventoryItemResponse Value403 { get; set; }

		[JsonProperty("Is404")]
		public bool Is404 { get; set; }

		/// <summary>
		/// The specified resource does not exist.
		/// </summary>
		[JsonProperty("Value404")]
		public DeleteInventoryItemResponse Value404 { get; set; }

		[JsonProperty("Is429")]
		public bool Is429 { get; set; }

		/// <summary>
		/// The frequency of requests was greater than allowed.
		/// </summary>
		[JsonProperty("Value429")]
		public DeleteInventoryItemResponse Value429 { get; set; }

		[JsonProperty("Is500")]
		public bool Is500 { get; set; }

		/// <summary>
		/// An unexpected condition occurred that prevented the server from fulfilling the request.
		/// </summary>
		[JsonProperty("Value500")]
		public DeleteInventoryItemResponse Value500 { get; set; }

		[JsonProperty("Is503")]
		public bool Is503 { get; set; }

		/// <summary>
		/// Temporary overloading or maintenance of the server.
		/// </summary>
		[JsonProperty("Value503")]
		public DeleteInventoryItemResponse Value503 { get; set; }
	}
}
