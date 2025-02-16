namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Response schema.
    /// </summary>
    public class GetFeedsResponse : BaseClass
    {
        /// <summary>
        /// The feeds.
        /// </summary>
        [JsonProperty("feeds")]
        [IsRequired]
        public FeedList Feeds { get; set; }

        /// <summary>
        /// Returned when the number of results exceeds pageSize. To get the next page of results, call
        /// the getFeeds operation with this token as the only parameter.
        /// </summary>
        [JsonProperty("nextToken")]
        public string NextToken { get; set; }
    }
}
