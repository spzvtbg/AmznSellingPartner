namespace AmznSellingPartner.Clients.Services.Services
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The shipping address for the service job.
    /// </summary>
    public class Address : BaseClass
    {
        /// <summary>
        /// The name of the person, business, or institution.
        /// </summary>
        [JsonProperty("name")]
        [IsRequired]
        public string Name { get; set; }

        /// <summary>
        /// The first line of the address.
        /// </summary>
        [JsonProperty("addressLine1")]
        [IsRequired]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Additional address information, if required.
        /// </summary>
        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Additional address information, if required.
        /// </summary>
        [JsonProperty("addressLine3")]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// The city.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The county.
        /// </summary>
        [JsonProperty("county")]
        public string County { get; set; }

        /// <summary>
        /// The district.
        /// </summary>
        [JsonProperty("district")]
        public string District { get; set; }

        /// <summary>
        /// The state or region.
        /// </summary>
        [JsonProperty("stateOrRegion")]
        public string StateOrRegion { get; set; }

        /// <summary>
        /// The postal code. This can contain letters, digits, spaces, and/or punctuation.
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The two digit country code, in ISO 3166-1 alpha-2 format.
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
