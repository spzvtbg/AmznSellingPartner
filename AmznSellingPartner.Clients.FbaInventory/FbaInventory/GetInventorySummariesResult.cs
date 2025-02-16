namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The payload schema for the getInventorySummaries operation.
    /// </summary>
    public class GetInventorySummariesResult : BaseClass
    {
        [JsonProperty("granularity")]
        [IsRequired]
        public Granularity Granularity { get; set; }

        [JsonProperty("inventorySummaries")]
        [IsRequired]
        public InventorySummaries InventorySummaries { get; set; }
    }
}
