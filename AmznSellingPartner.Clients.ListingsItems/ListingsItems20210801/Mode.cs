namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Mode
    {
        /// <summary>
        /// Indicates the submitted data should be validated using the values provided in the payload and
        /// validation errors the selling partner account may face. This will synchronously perform the
        /// same checks that are preformed on submissions after being accepted for processing, but without
        /// persisting to the selling partner's catalog.
        /// </summary>
        [EnumMember(Value = "VALIDATION_PREVIEW")]
        VALIDATION_PREVIEW,
    }
}
