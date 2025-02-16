namespace AmznSellingPartner.Clients.Finances.Transfers20240601
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the `initiatePayout` operation.
    /// </summary>
    public class InitiatePayoutResponse : BaseClass
    {
        /// <summary>
        /// The financial event group ID for a successfully initiated payout. You can use this ID to track
        /// payout information.
        /// </summary>
        [JsonProperty("payoutReferenceId")]
        [IsRequired]
        public string PayoutReferenceId { get; set; }
    }
}
