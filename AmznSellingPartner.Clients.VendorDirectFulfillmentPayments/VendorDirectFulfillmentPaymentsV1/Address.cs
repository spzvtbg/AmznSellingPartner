namespace AmznSellingPartner.Clients.VendorDirectFulfillmentPayments.VendorDirectFulfillmentPaymentsV1
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Address of the party.
    /// </summary>
    public class Address : BaseClass
    {
        /// <summary>
        /// The name of the person, business or institution at that address.
        /// </summary>
        [JsonProperty("name")]
        [IsRequired]
        public string Name { get; set; }

        /// <summary>
        /// First line of the address.
        /// </summary>
        [JsonProperty("addressLine1")]
        [IsRequired]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Additional street address information, if required.
        /// </summary>
        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Additional street address information, if required.
        /// </summary>
        [JsonProperty("addressLine3")]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// The city where the person, business or institution is located.
        /// </summary>
        [JsonProperty("city")]
        [IsRequired]
        public string City { get; set; }

        /// <summary>
        /// The county where person, business or institution is located.
        /// </summary>
        [JsonProperty("county")]
        public string County { get; set; }

        /// <summary>
        /// The district where person, business or institution is located.
        /// </summary>
        [JsonProperty("district")]
        public string District { get; set; }

        /// <summary>
        /// The state or region where person, business or institution is located.
        /// </summary>
        [JsonProperty("stateOrRegion")]
        [IsRequired]
        public string StateOrRegion { get; set; }

        /// <summary>
        /// The postal code of that address. It conatins a series of letters or digits or both, sometimes
        /// including spaces or punctuation.
        /// </summary>
        [JsonProperty("postalCode")]
        [IsRequired]
        public string PostalCode { get; set; }

        /// <summary>
        /// The two digit country code in ISO 3166-1 alpha-2 format.
        /// </summary>
        [JsonProperty("countryCode")]
        [IsRequired]
        public string CountryCode { get; set; }

        /// <summary>
        /// The phone number of the person, business or institution located at that address.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
