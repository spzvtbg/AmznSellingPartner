namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the CreateInventoryItem operation.
	/// </summary>
	public class CreateInventoryItemResponse : BaseClass
	{
		/// <summary>
		/// One or more unexpected errors occurred during the CreateInventoryItem operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
