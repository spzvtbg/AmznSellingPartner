namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;

    /// <summary>
    /// UnmanifestedShipmentLocation info
    /// </summary>
    public class UnmanifestedShipmentLocation : BaseClass
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Its Last Manifest Date.
        /// </summary>
        [JsonProperty("lastManifestDate")]
        public DateTimeValue LastManifestDate { get; set; }
    }
}
