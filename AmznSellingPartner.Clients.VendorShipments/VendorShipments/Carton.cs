namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// Details of the carton/package being shipped.
    /// </summary>
    public class Carton : BaseClass
    {
        /// <summary>
        /// A list of carton identifiers.
        /// </summary>
        [JsonProperty("cartonIdentifiers")]
        public List<ContainerIdentification> CartonIdentifiers { get; set; }

        /// <summary>
        /// Carton sequence number for the carton. The first carton will be 001, the second 002, and so
        /// on. This number is used as a reference to refer to this carton from the pallet level.
        /// </summary>
        [JsonProperty("cartonSequenceNumber")]
        [IsRequired]
        public string CartonSequenceNumber { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("weight")]
        public Weight Weight { get; set; }

        /// <summary>
        /// This is required to be provided for every carton in the small parcel shipments.
        /// </summary>
        [JsonProperty("trackingNumber")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// A list of container item details.
        /// </summary>
        [JsonProperty("items")]
        [IsRequired]
        public List<ContainerItem> Items { get; set; }
    }
}
