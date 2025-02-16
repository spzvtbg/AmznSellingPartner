namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Specific details to identify a place.
    /// </summary>
    public class Address : BaseClass
    {
        /// <summary>
        /// Street address information.
        /// </summary>
        [JsonProperty("addressLine1")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(180)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Additional street address information.
        /// </summary>
        [JsonProperty("addressLine2")]
        [MinLength(1)]
        [MaxLength(60)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The city.
        /// </summary>
        [JsonProperty("city")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(30)]
        public string City { get; set; }

        /// <summary>
        /// The name of the business.
        /// </summary>
        [JsonProperty("companyName")]
        [MinLength(1)]
        [MaxLength(50)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The country code in two-character ISO 3166-1 alpha-2 format.
        /// </summary>
        [JsonProperty("countryCode")]
        [IsRequired]
        [Pattern("^[A-Z]{2}")]
        [MinLength(2)]
        [MaxLength(2)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        [JsonProperty("email")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string Email { get; set; }

        /// <summary>
        /// The name of the individual who is the primary contact.
        /// </summary>
        [JsonProperty("name")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonProperty("phoneNumber")]
        [MinLength(1)]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The postal code.
        /// </summary>
        [JsonProperty("postalCode")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(32)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The state or province code.
        /// </summary>
        [JsonProperty("stateOrProvinceCode")]
        [MinLength(1)]
        [MaxLength(64)]
        public string StateOrProvinceCode { get; set; }
    }
}
