namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
    using Newtonsoft.Json;

    /// <summary>
    /// The dynamic parameters required by the notification templated specified by `templateId`.
    /// </summary>
    public class NotificationParameters : BaseClass
    {
        [JsonProperty("")]
        public object AdditionalValue { get; set; }
    }
}
