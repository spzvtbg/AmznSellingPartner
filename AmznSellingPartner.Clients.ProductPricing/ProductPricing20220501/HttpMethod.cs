namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The HTTP method associated with an individual request within a batch.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HttpMethod
    {
        /// <summary>
        /// GET
        /// </summary>
        [EnumMember(Value = "GET")]
        GET,

        /// <summary>
        /// PUT
        /// </summary>
        [EnumMember(Value = "PUT")]
        PUT,

        /// <summary>
        /// PATCH
        /// </summary>
        [EnumMember(Value = "PATCH")]
        PATCH,

        /// <summary>
        /// DELETE
        /// </summary>
        [EnumMember(Value = "DELETE")]
        DELETE,

        /// <summary>
        /// POST
        /// </summary>
        [EnumMember(Value = "POST")]
        POST,
    }
}
