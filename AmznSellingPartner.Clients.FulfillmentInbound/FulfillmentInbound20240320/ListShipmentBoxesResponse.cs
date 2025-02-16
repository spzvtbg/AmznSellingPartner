namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The `listShipmentBoxes` response.
    /// </summary>
    public class ListShipmentBoxesResponse : BaseClass
    {
        /// <summary>
        /// A list of boxes in a shipment.
        /// </summary>
        [JsonProperty("boxes")]
        [IsRequired]
        public List<Box> Boxes { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }
}
