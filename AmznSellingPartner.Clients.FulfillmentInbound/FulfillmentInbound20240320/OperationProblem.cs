namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// A problem with additional properties persisted to an operation.
    /// </summary>
    public class OperationProblem : BaseClass
    {
        /// <summary>
        /// An error code that identifies the type of error that occurred.
        /// </summary>
        [JsonProperty("code")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(256)]
        public string Code { get; set; }

        /// <summary>
        /// Additional details that can help the caller understand or fix the issue.
        /// </summary>
        [JsonProperty("details")]
        [MinLength(0)]
        [MaxLength(8192)]
        public string Details { get; set; }

        /// <summary>
        /// A message that describes the error condition.
        /// </summary>
        [JsonProperty("message")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(2048)]
        public string Message { get; set; }

        /// <summary>
        /// The severity of the problem. Possible values: `WARNING`, `ERROR`.
        /// </summary>
        [JsonProperty("severity")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(1024)]
        public string Severity { get; set; }
    }
}
