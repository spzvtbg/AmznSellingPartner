namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/feeds/2021-06-30/feeds")]
    public class AmznCreateFeedRequest : BaseHttpRequest
    {
        /// <summary>
        /// Information required to create the feed.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public CreateFeedSpecification Body { get; set; }
    }
}
