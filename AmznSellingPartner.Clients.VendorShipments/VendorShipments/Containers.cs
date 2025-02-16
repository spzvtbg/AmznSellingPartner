namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// A list of the items in this transportation and their associated inner container details. If
    /// any of the item detail fields are common at a carton or a pallet level, provide them at the
    /// corresponding carton or pallet level.
    /// </summary>
    public class Containers : BaseClass
    {
        /// <summary>
        /// The type of container.
        /// </summary>
        [JsonProperty("containerType")]
        [IsRequired]
        public ContainerType ContainerType { get; set; }

        /// <summary>
        /// An integer that must be submitted for multi-box shipments only, where one item may come in
        /// separate packages.
        /// </summary>
        [JsonProperty("containerSequenceNumber")]
        public string ContainerSequenceNumber { get; set; }

        /// <summary>
        /// A list of carton identifiers.
        /// </summary>
        [JsonProperty("containerIdentifiers")]
        [IsRequired]
        public List<ContainerIdentification> ContainerIdentifiers { get; set; }

        /// <summary>
        /// The tracking number used for identifying the shipment.
        /// </summary>
        [JsonProperty("trackingNumber")]
        public string TrackingNumber { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("weight")]
        public Weight Weight { get; set; }

        /// <summary>
        /// Number of layers per pallet.
        /// </summary>
        [JsonProperty("tier")]
        public int Tier { get; set; }

        /// <summary>
        /// Number of cartons per layer on the pallet.
        /// </summary>
        [JsonProperty("block")]
        public int Block { get; set; }

        [JsonProperty("innerContainersDetails")]
        public InnerContainersDetails InnerContainersDetails { get; set; }

        /// <summary>
        /// A list of packed items.
        /// </summary>
        [JsonProperty("packedItems")]
        public List<PackedItems> PackedItems { get; set; }
    }
}
