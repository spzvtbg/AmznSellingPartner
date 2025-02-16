namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;

    /// <summary>
    /// The location where the person, business or institution is located.
    /// </summary>
    public class Location : BaseClass
    {
        [JsonProperty("stateOrRegion")]
        public StateOrRegion StateOrRegion { get; set; }

        [JsonProperty("city")]
        public City City { get; set; }

        [JsonProperty("countryCode")]
        public CountryCode CountryCode { get; set; }

        [JsonProperty("postalCode")]
        public PostalCode PostalCode { get; set; }
    }
}
