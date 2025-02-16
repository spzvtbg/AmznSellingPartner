namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The details of the container label.
    /// </summary>
    public class ContainerLabel : BaseClass
    {
        /// <summary>
        /// The container (pallet) tracking identifier from the shipping carrier.
        /// </summary>
        [JsonProperty("containerTrackingNumber")]
        public string ContainerTrackingNumber { get; set; }

        /// <summary>
        /// The `Base64encoded` string of the container label content.
        /// </summary>
        [JsonProperty("content")]
        [IsRequired]
        public string Content { get; set; }

        /// <summary>
        /// The format of the container label.
        /// </summary>
        [JsonProperty("format")]
        [IsRequired]
        public ContainerLabelFormat Format { get; set; }
    }
}
