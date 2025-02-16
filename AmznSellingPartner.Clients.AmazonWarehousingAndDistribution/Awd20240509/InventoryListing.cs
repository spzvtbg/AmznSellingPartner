namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// AWD inventory payload.
    /// </summary>
    public class InventoryListing : BaseClass
    {
        /// <summary>
        /// List of inventory summaries.
        /// </summary>
        [JsonProperty("inventory")]
        [IsRequired]
        public List<InventorySummary> Inventory { get; set; }

        /// <summary>
        /// Token to retrieve the next set of paginated results.
        /// </summary>
        [JsonProperty("nextToken")]
        public string NextToken { get; set; }
    }
}
