namespace AmznSellingPartner.Clients.ProductTypeDefinitions.DefinitionsProductTypes20200901
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RequirementsEnforced
    {
        /// <summary>
        /// Request schema with required and conditionally required attributes enforced (used for full
        /// payload validation).
        /// </summary>
        [EnumMember(Value = "ENFORCED")]
        ENFORCED,

        /// <summary>
        /// Request schema with required and conditionally required attributes not enforced (used for partial
        /// payload validation, such as for single attributes).
        /// </summary>
        [EnumMember(Value = "NOT_ENFORCED")]
        NOT_ENFORCED,
    }
}
