namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeedbackActionCode
    {
        /// <summary>
        /// The seller completed the action attached to the posted notification.
        /// </summary>
        [EnumMember(Value = "SELLER_ACTION_COMPLETED")]
        SELLER_ACTION_COMPLETED,
    }
}
