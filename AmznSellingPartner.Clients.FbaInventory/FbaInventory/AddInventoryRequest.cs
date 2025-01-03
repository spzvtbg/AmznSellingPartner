namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using Newtonsoft.Json;

	/// <summary>
	/// The object with the list of Inventory to be added
	/// </summary>
	public class AddInventoryRequest : BaseClass
	{
		[JsonProperty("inventoryItems")]
		public InventoryItems InventoryItems { get; set; }
	}
}
