namespace AmznSellingPartner.Clients.Notifications.Notifications
{
    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the `getSubscriptionById` operation.
    /// </summary>
    public class GetSubscriptionByIdResponse : BaseClass
    {
        /// <summary>
        /// The payload for the `getSubscriptionById` operation.
        /// </summary>
        [JsonProperty("payload")]
        public Subscription Payload { get; set; }

        /// <summary>
        /// An unexpected condition occurred during the `getSubscriptionById` operation.
        /// </summary>
        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
