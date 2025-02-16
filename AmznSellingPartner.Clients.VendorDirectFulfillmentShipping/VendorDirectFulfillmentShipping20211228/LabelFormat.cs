namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LabelFormat
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
