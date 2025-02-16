namespace AmznSellingPartner.Clients.FbaInboundEligibility.FbaInbound
{
    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the getItemEligibilityPreview operation.
    /// </summary>
    public class GetItemEligibilityPreviewResponse : BaseClass
    {
        /// <summary>
        /// The payload for the getItemEligibilityPreview operation.
        /// </summary>
        [JsonProperty("payload")]
        public ItemEligibilityPreview Payload { get; set; }

        /// <summary>
        /// An unexpected condition occurred during the GetItemEligibilityPreview operation.
        /// </summary>
        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
