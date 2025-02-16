namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;

    /// <summary>
    /// The request schema for remove the Carrier Account associated with the provided merchant.
    /// </summary>
    public class UnlinkCarrierAccountRequest : BaseClass
    {
        [JsonProperty("clientReferenceDetails")]
        public ClientReferenceDetails ClientReferenceDetails { get; set; }
    }
}
