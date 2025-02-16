namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/inbound/fba/2024-03-20/items/labels")]
    public class AmznCreateMarketplaceItemLabelsRequest : BaseHttpRequest
    {
        /// <summary>
        /// The body of the request to `createMarketplaceItemLabels`.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public CreateMarketplaceItemLabelsRequest Body { get; set; }
    }
}
