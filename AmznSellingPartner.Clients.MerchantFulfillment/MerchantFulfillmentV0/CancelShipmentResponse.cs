namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using Newtonsoft.Json;

    /// <summary>
    /// Response schema.
    /// </summary>
    public class CancelShipmentResponse : BaseClass
    {
        /// <summary>
        /// The payload for the `cancelShipment` operation.
        /// </summary>
        [JsonProperty("payload")]
        public Shipment Payload { get; set; }

        /// <summary>
        /// One or more unexpected errors occurred during the `cancelShipment` operation.
        /// </summary>
        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
