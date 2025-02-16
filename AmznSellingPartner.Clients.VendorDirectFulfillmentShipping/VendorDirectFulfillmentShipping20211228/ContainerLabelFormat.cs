namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The format of the container label.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContainerLabelFormat
    {
        /// <summary>
        /// Portable Network Graphics (png) format.
        /// </summary>
        [EnumMember(Value = "PNG")]
        PNG,

        /// <summary>
        /// Zebra Programming Language (zpl) format.
        /// </summary>
        [EnumMember(Value = "ZPL")]
        ZPL,
    }
}
