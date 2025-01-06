namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using Newtonsoft.Json;

	public class AddInventoryPostResponse : BaseHttpResponse<AddInventoryPostResponse>
	{
		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// OK
		/// </summary>
		public AddInventoryResponse AddInventoryResponse { get; set; } 
	}
}
