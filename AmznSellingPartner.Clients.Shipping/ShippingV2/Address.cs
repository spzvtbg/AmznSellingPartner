namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The address.
    /// </summary>
    public class Address : BaseClass
    {
        /// <summary>
        /// The name of the person, business or institution at the address.
        /// </summary>
        [JsonProperty("name")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// The first line of the address.
        /// </summary>
        [JsonProperty("addressLine1")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(60)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Additional address information, if required.
        /// </summary>
        [JsonProperty("addressLine2")]
        [MinLength(1)]
        [MaxLength(60)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Additional address information, if required.
        /// </summary>
        [JsonProperty("addressLine3")]
        [MinLength(1)]
        [MaxLength(60)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// The name of the business or institution associated with the address.
        /// </summary>
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("stateOrRegion")]
        [IsRequired]
        public StateOrRegion StateOrRegion { get; set; }

        [JsonProperty("city")]
        [IsRequired]
        public City City { get; set; }

        [JsonProperty("countryCode")]
        [IsRequired]
        public CountryCode CountryCode { get; set; }

        [JsonProperty("postalCode")]
        [IsRequired]
        public PostalCode PostalCode { get; set; }

        /// <summary>
        /// The email address of the contact associated with the address.
        /// </summary>
        [JsonProperty("email")]
        [MaxLength(64)]
        public string Email { get; set; }

        /// <summary>
        /// The phone number of the person, business or institution located at that address, including
        /// the country calling code.
        /// </summary>
        [JsonProperty("phoneNumber")]
        [MinLength(1)]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [JsonProperty("geocode")]
        public Geocode Geocode { get; set; }
    }
}
