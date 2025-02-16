namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The seller's contact information.
    /// </summary>
    public class ContactInformation : BaseClass
    {
        /// <summary>
        /// The email address.
        /// </summary>
        [JsonProperty("email")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string Email { get; set; }

        /// <summary>
        /// The contact's name.
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
        [IsRequired]
        [MinLength(1)]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
    }
}
