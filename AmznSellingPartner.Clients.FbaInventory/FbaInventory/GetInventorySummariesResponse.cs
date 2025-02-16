namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Response schema.
    /// </summary>
    public class GetInventorySummariesResponse : BaseClass
    {
        /// <summary>
        /// The payload for the getInventorySummaries operation.
        /// </summary>
        [JsonProperty("payload")]
        public GetInventorySummariesResult Payload { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// One or more unexpected errors occurred during the getInventorySummaries operation.
        /// </summary>
        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
