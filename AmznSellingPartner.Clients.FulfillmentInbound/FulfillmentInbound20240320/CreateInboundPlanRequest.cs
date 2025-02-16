namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The `createInboundPlan` request.
    /// </summary>
    public class CreateInboundPlanRequest : BaseClass
    {
        /// <summary>
        /// Marketplaces where the items need to be shipped to. Currently only one marketplace can be selected
        /// in this request.
        /// </summary>
        [JsonProperty("destinationMarketplaces")]
        [IsRequired]
        [MinItems(1)]
        [MaxItems(1)]
        public List<string> DestinationMarketplaces { get; set; }

        /// <summary>
        /// Items included in this plan.
        /// </summary>
        [JsonProperty("items")]
        [IsRequired]
        [MinItems(1)]
        [MaxItems(2000)]
        public List<ItemInput> Items { get; set; }

        /// <summary>
        /// Name for the Inbound Plan. If one isn't provided, a default name will be provided.
        /// </summary>
        [JsonProperty("name")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name { get; set; }

        [JsonProperty("sourceAddress")]
        [IsRequired]
        public AddressInput SourceAddress { get; set; }
    }
}
