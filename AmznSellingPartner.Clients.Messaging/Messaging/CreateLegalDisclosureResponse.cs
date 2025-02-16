namespace AmznSellingPartner.Clients.Messaging.Messaging
{
    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the createLegalDisclosure operation.
    /// </summary>
    public class CreateLegalDisclosureResponse : BaseClass
    {
        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
