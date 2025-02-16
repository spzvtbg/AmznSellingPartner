namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// Supported invoice file extensions.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FileFormat
    {
        /// <summary>
        /// The invoice file is in XML format.
        /// </summary>
        [EnumMember(Value = "XML")]
        XML,
    }
}
