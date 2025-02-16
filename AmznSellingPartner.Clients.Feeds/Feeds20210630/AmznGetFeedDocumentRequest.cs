namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/feeds/2021-06-30/documents/{feedDocumentId}")]
    public class AmznGetFeedDocumentRequest : BaseHttpRequest
    {
        /// <summary>
        /// The identifier of the feed document.
        /// </summary>
        [InPath("feedDocumentId")]
        [IsRequired]
        public string FeedDocumentId { get; set; }
    }
}
