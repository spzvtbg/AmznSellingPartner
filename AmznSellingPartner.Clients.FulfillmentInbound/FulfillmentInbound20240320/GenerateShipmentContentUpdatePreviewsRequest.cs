namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The `GenerateShipmentContentUpdatePreviews` request.
    /// </summary>
    public class GenerateShipmentContentUpdatePreviewsRequest : BaseClass
    {
        /// <summary>
        /// A list of boxes that will be present in the shipment after the update.
        /// </summary>
        [JsonProperty("boxes")]
        [IsRequired]
        [MinItems(1)]
        [MaxItems(5000)]
        public List<BoxUpdateInput> Boxes { get; set; }

        /// <summary>
        /// A list of all items that will be present in the shipment after the update.
        /// </summary>
        [JsonProperty("items")]
        [IsRequired]
        [MinItems(1)]
        [MaxItems(2000)]
        public List<ItemInput> Items { get; set; }
    }
}
