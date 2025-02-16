namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The `generatePlacementOptions` request.
    /// </summary>
    public class GeneratePlacementOptionsRequest : BaseClass
    {
        /// <summary>
        /// Custom placement options you want to add to the plan. This is only used for the India (IN -
        /// A21TJRUUN4KGV) marketplace.
        /// </summary>
        [JsonProperty("customPlacement")]
        public List<CustomPlacementInput> CustomPlacement { get; set; }
    }
}
