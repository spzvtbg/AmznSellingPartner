namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the AddInventory operation
	/// </summary>
	public class AddInventoryResponse : BaseClass
	{
		/// <summary>
		/// One or more unexpected errors occurred during the AddInventory operation
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
