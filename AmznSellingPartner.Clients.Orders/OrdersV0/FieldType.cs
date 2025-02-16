namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FieldType
    {
        /// <summary>
        /// This field is a text representation of the response collected from the regulatory form.
        /// </summary>
        [EnumMember(Value = "Text")]
        Text,

        /// <summary>
        /// This field contains a link to an attachment collected from the regulatory form.
        /// </summary>
        [EnumMember(Value = "FileAttachment")]
        FileAttachment,
    }
}
