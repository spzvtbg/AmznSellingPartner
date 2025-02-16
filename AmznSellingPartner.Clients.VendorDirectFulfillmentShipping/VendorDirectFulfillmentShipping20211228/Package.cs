namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The package that is associated with the container.
    /// </summary>
    public class Package : BaseClass
    {
        /// <summary>
        /// The tracking number on the label of shipment package, that you can fetch from the `shippingLabels`
        /// response. You can also scan the bar code on the shipping label to get the tracking number.
        /// </summary>
        [JsonProperty("packageTrackingNumber")]
        [IsRequired]
        public string PackageTrackingNumber { get; set; }
    }
}
