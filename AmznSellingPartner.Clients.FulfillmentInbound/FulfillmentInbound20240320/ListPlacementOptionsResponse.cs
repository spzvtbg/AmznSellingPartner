namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The `listPlacementOptions` response.
    /// </summary>
    public class ListPlacementOptionsResponse : BaseClass
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Placement options generated for the inbound plan.
        /// </summary>
        [JsonProperty("placementOptions")]
        [IsRequired]
        public List<PlacementOption> PlacementOptions { get; set; }
    }
}
