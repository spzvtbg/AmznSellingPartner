namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The name, address, and tax details of a party.
    /// </summary>
    public class PartyIdentification : BaseClass
    {
        /// <summary>
        /// The identifier of the party.
        /// </summary>
        [JsonProperty("partyId")]
        [IsRequired]
        public string PartyId { get; set; }

        /// <summary>
        /// The address of the party.
        /// </summary>
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// The tax registration details of the party.
        /// </summary>
        [JsonProperty("taxRegistrationDetails")]
        public List<TaxRegistrationDetails> TaxRegistrationDetails { get; set; }
    }
}
