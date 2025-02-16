namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Error response returned when the request is unsuccessful.
    /// </summary>
    public class Error : BaseClass
    {
        /// <summary>
        /// An error code that identifies the type of error that occurred.
        /// </summary>
        [JsonProperty("code")]
        [IsRequired]
        [MinLength(1)]
        public string Code { get; set; }

        /// <summary>
        /// A message that describes the error condition.
        /// </summary>
        [JsonProperty("message")]
        [IsRequired]
        [MinLength(1)]
        public string Message { get; set; }

        /// <summary>
        /// Additional details that can help the caller understand or fix the issue.
        /// </summary>
        [JsonProperty("details")]
        [MinLength(1)]
        public string Details { get; set; }
    }
}
