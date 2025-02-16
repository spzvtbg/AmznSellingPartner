namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The postal address information.
    /// </summary>
    public class Address : BaseClass
    {
        [JsonProperty("Name")]
        [IsRequired]
        public AddressName Name { get; set; }

        [JsonProperty("AddressLine1")]
        [IsRequired]
        public AddressLine1 AddressLine1 { get; set; }

        [JsonProperty("AddressLine2")]
        public AddressLine2 AddressLine2 { get; set; }

        [JsonProperty("AddressLine3")]
        public AddressLine3 AddressLine3 { get; set; }

        [JsonProperty("DistrictOrCounty")]
        public DistrictOrCounty DistrictOrCounty { get; set; }

        [JsonProperty("Email")]
        [IsRequired]
        public EmailAddress Email { get; set; }

        [JsonProperty("City")]
        [IsRequired]
        public City City { get; set; }

        [JsonProperty("StateOrProvinceCode")]
        public StateOrProvinceCode StateOrProvinceCode { get; set; }

        [JsonProperty("PostalCode")]
        [IsRequired]
        public PostalCode PostalCode { get; set; }

        [JsonProperty("CountryCode")]
        [IsRequired]
        public CountryCode CountryCode { get; set; }

        [JsonProperty("Phone")]
        [IsRequired]
        public PhoneNumber Phone { get; set; }
    }
}
