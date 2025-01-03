namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The payload schema for the getInventorySummaries operation
	/// </summary>
	public class GetInventorySummariesResult : BaseClass
	{
		[IsRequired]
		[JsonProperty("granularity")]
		public Granularity Granularity { get; set; }

		[IsRequired]
		[JsonProperty("inventorySummaries")]
		public InventorySummaries InventorySummaries { get; set; }
	}
}
