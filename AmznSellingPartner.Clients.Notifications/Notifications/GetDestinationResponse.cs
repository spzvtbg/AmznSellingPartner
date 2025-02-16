namespace AmznSellingPartner.Clients.Notifications.Notifications
{
    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the `getDestination` operation.
    /// </summary>
    public class GetDestinationResponse : BaseClass
    {
        /// <summary>
        /// The payload for the `getDestination` operation.
        /// </summary>
        [JsonProperty("payload")]
        public Destination Payload { get; set; }

        /// <summary>
        /// One or more unexpected errors occurred during the `getDestination` operation.
        /// </summary>
        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
