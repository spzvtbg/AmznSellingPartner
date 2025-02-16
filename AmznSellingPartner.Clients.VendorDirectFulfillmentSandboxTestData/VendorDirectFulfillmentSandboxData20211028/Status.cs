namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        /// <summary>
        /// Transaction has failed.
        /// </summary>
        [EnumMember(Value = "FAILURE")]
        FAILURE,

        /// <summary>
        /// Transaction is in process.
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        PROCESSING,

        /// <summary>
        /// Transaction has completed successfully.
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        SUCCESS,
    }
}
