namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The status of an operation.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OperationStatus
    {
        /// <summary>
        /// Indicates a request has successfully finished processing.
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        SUCCESS,

        /// <summary>
        /// Indicates a request has finished processing but is in a failed state.
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED,

        /// <summary>
        /// Indicates a request is still processing.
        /// </summary>
        [EnumMember(Value = "IN_PROGRESS")]
        IN_PROGRESS,
    }
}
