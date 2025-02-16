namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The reason that the item is invalid for return.
    /// </summary>
    public class InvalidItemReason : BaseClass
    {
        [JsonProperty("invalidItemReasonCode")]
        [IsRequired]
        public InvalidItemReasonCode InvalidItemReasonCode { get; set; }

        /// <summary>
        /// A human readable description of the invalid item reason code.
        /// </summary>
        [JsonProperty("description")]
        [IsRequired]
        public string Description { get; set; }
    }
}
