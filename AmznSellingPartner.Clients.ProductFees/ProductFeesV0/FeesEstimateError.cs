namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// An unexpected error occurred during this operation.
    /// </summary>
    public class FeesEstimateError : BaseClass
    {
        /// <summary>
        /// An error type, identifying either the receiver or the sender as the originator of the erro
        /// r.
        /// </summary>
        [JsonProperty("Type")]
        [IsRequired]
        public string Type { get; set; }

        /// <summary>
        /// An error code that identifies the type of error that occurred.
        /// </summary>
        [JsonProperty("Code")]
        [IsRequired]
        public string Code { get; set; }

        /// <summary>
        /// A message that describes the error condition.
        /// </summary>
        [JsonProperty("Message")]
        [IsRequired]
        public string Message { get; set; }

        [JsonProperty("Detail")]
        [IsRequired]
        public FeesEstimateErrorDetail Detail { get; set; }
    }
}
