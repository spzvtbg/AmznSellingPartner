namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/fba/outbound/2020-07-01/fulfillmentOrders/preview")]
    public class AmznGetFulfillmentPreviewRequest : BaseHttpRequest
    {
        /// <summary>
        /// GetFulfillmentPreviewRequest parameter
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public GetFulfillmentPreviewRequest Body { get; set; }
    }
}
