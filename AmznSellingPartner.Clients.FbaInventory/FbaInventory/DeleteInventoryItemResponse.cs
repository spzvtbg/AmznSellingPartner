namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the DeleteInventoryItem operation.
	/// </summary>
	public class DeleteInventoryItemResponse : BaseClass
	{
		/// <summary>
		/// One or more unexpected errors occurred during the DeleteInventoryItem operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
