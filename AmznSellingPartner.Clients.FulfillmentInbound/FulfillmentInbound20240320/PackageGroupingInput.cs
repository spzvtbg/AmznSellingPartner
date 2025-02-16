namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// Packing information for the inbound plan.
    /// </summary>
    public class PackageGroupingInput : BaseClass
    {
        /// <summary>
        /// Box level information being provided.
        /// </summary>
        [JsonProperty("boxes")]
        [IsRequired]
        [MinItems(1)]
        [MaxItems(5000)]
        public List<BoxInput> Boxes { get; set; }

        /// <summary>
        /// The ID of the `packingGroup` that packages are grouped according to. The `PackingGroupId` can
        /// only be provided before placement confirmation, and it must belong to the confirmed `PackingOption`.
        /// One of `ShipmentId` or `PackingGroupId` must be provided with every request.
        /// </summary>
        [JsonProperty("packingGroupId")]
        [Pattern("^[a-zA-Z0-9-]*")]
        [MinLength(38)]
        [MaxLength(38)]
        public string PackingGroupId { get; set; }

        /// <summary>
        /// The ID of the shipment that packages are grouped according to. The `ShipmentId` can only be
        /// provided after placement confirmation, and the shipment must belong to the confirmed placement
        /// option. One of `ShipmentId` or `PackingGroupId` must be provided with every request.
        /// </summary>
        [JsonProperty("shipmentId")]
        [Pattern("^[a-zA-Z0-9-]*")]
        [MinLength(38)]
        [MaxLength(38)]
        public string ShipmentId { get; set; }
    }
}
