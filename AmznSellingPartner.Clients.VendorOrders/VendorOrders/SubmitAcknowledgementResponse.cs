namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the submitAcknowledgement operation
    /// </summary>
    public class SubmitAcknowledgementResponse : BaseClass
    {
        /// <summary>
        /// The payload for the submitAcknowledgement operation.
        /// </summary>
        [JsonProperty("payload")]
        public TransactionId Payload { get; set; }

        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
