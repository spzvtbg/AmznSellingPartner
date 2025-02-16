namespace AmznSellingPartner.Clients.Messaging.Messaging
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    [HttpPost("/messaging/v1/orders/{amazonOrderId}/messages/confirmServiceDetails")]
    public class AmznCreateConfirmServiceDetailsRequest : BaseHttpRequest
    {
        /// <summary>
        /// An Amazon order identifier. This identifies the order for which a message is sent.
        /// </summary>
        [InPath("amazonOrderId")]
        [IsRequired]
        public string AmazonOrderId { get; set; }

        /// <summary>
        /// A marketplace identifier. This identifies the marketplace in which the order was placed. You
        /// can only specify one marketplace.
        /// </summary>
        [InQuery("marketplaceIds")]
        [IsRequired]
        [MaxItems(1)]
        public CsvValue<string> MarketplaceIds { get; set; }

        /// <summary>
        /// This contains the message body for a message.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public CreateConfirmServiceDetailsRequest Body { get; set; }
    }
}
