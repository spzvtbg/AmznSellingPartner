namespace AmznSellingPartner.Clients.Messaging.Messaging
{
    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the confirmCustomizationDetails operation.
    /// </summary>
    public class CreateConfirmCustomizationDetailsResponse : BaseClass
    {
        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
