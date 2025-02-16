namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the `createFulfillmentReturn` operation.
    /// </summary>
    public class CreateFulfillmentReturnResponse : BaseClass
    {
        /// <summary>
        /// The payload for the `createFulfillmentReturn` operation.
        /// </summary>
        [JsonProperty("payload")]
        public CreateFulfillmentReturnResult Payload { get; set; }

        /// <summary>
        /// One or more unexpected errors occurred during the `createFulfillmentReturn` operation.
        /// </summary>
        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
