namespace AmznSellingPartner.Clients.VendorDirectFulfillmentInventory.VendorDirectFulfillmentInventoryV1
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Name, address and tax details of a party.
    /// </summary>
    public class PartyIdentification : BaseClass
    {
        /// <summary>
        /// Assigned identification for the party.
        /// </summary>
        [JsonProperty("partyId")]
        [IsRequired]
        public string PartyId { get; set; }
    }
}
