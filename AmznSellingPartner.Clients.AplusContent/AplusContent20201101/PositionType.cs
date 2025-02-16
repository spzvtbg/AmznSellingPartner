namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The relative positioning of content.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PositionType
    {
        /// <summary>
        /// Indicates that the content is to be positioned on the left side of the module.
        /// </summary>
        [EnumMember(Value = "LEFT")]
        LEFT,

        /// <summary>
        /// Indicates that the content is to be positioned on the right side of the module.
        /// </summary>
        [EnumMember(Value = "RIGHT")]
        RIGHT,
    }
}
