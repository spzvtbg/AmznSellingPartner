namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Tax registration details of the entity.
    /// </summary>
    public class TaxRegistrationDetails : BaseClass
    {
        /// <summary>
        /// Tax registration type for the entity.
        /// </summary>
        [JsonProperty("taxRegistrationType")]
        public TaxRegistrationType TaxRegistrationType { get; set; }

        /// <summary>
        /// Tax registration number for the party. For example, VAT ID.
        /// </summary>
        [JsonProperty("taxRegistrationNumber")]
        [IsRequired]
        public string TaxRegistrationNumber { get; set; }

        /// <summary>
        /// Address associated with the tax registration number.
        /// </summary>
        [JsonProperty("taxRegistrationAddress")]
        public Address TaxRegistrationAddress { get; set; }

        /// <summary>
        /// Tax registration message that can be used for additional tax related details.
        /// </summary>
        [JsonProperty("taxRegistrationMessages")]
        public string TaxRegistrationMessages { get; set; }
    }
}
