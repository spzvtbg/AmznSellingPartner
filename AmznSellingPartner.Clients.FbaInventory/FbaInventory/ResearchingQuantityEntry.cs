namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The misplaced or warehouse damaged inventory that is actively being confirmed at our fulfillment
    /// centers.
    /// </summary>
    public class ResearchingQuantityEntry : BaseClass
    {
        /// <summary>
        /// The duration of the research.
        /// </summary>
        [JsonProperty("name")]
        [IsRequired]
        public Name Name { get; set; }

        /// <summary>
        /// The number of units.
        /// </summary>
        [JsonProperty("quantity")]
        [IsRequired]
        public int Quantity { get; set; }
    }
}
