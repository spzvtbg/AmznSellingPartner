namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using Newtonsoft.Json;

	public class CreateInventoryItemPostResponse : BaseHttpResponse<CreateInventoryItemPostResponse>
	{
		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// OK
		/// </summary>
		public CreateInventoryItemResponse CreateInventoryItemResponse { get; set; } 
	}
}
