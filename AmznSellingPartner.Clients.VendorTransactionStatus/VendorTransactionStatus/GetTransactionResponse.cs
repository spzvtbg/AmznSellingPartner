namespace AmznSellingPartner.Clients.VendorTransactionStatus.VendorTransactionStatus
{
    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the getTransaction operation.
    /// </summary>
    public class GetTransactionResponse : BaseClass
    {
        /// <summary>
        /// The response payload for the getTransaction operation.
        /// </summary>
        [JsonProperty("payload")]
        public TransactionStatus Payload { get; set; }

        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
