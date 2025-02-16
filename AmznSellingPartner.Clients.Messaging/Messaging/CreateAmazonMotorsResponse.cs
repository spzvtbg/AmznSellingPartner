namespace AmznSellingPartner.Clients.Messaging.Messaging
{
    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the createAmazonMotors operation.
    /// </summary>
    public class CreateAmazonMotorsResponse : BaseClass
    {
        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
