namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/feeds/2021-06-30/feeds/{feedId}")]
    public class AmznGetFeedRequest : BaseHttpRequest
    {
        /// <summary>
        /// The identifier for the feed. This identifier is unique only in combination with a seller I
        /// D.
        /// </summary>
        [InPath("feedId")]
        [IsRequired]
        public string FeedId { get; set; }
    }
}
