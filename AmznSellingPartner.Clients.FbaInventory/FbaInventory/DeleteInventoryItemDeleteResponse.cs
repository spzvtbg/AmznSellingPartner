namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using Newtonsoft.Json;

	public class DeleteInventoryItemDeleteResponse : BaseHttpResponse<DeleteInventoryItemDeleteResponse>
	{
		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// OK
		/// </summary>
		public DeleteInventoryItemResponse DeleteInventoryItemResponse { get; set; } 
	}
}
