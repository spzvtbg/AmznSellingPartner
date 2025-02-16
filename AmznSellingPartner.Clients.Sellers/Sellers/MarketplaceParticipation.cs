namespace AmznSellingPartner.Clients.Sellers.Sellers
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    public class MarketplaceParticipation : BaseClass
    {
        [JsonProperty("marketplace")]
        [IsRequired]
        public Marketplace Marketplace { get; set; }

        [JsonProperty("participation")]
        [IsRequired]
        public Participation Participation { get; set; }

        /// <summary>
        /// The name of the seller's store as displayed in the marketplace.
        /// </summary>
        [JsonProperty("storeName")]
        [IsRequired]
        public string StoreName { get; set; }
    }
}
