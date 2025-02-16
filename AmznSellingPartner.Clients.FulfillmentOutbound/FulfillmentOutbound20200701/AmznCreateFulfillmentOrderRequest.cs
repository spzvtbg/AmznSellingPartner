namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/fba/outbound/2020-07-01/fulfillmentOrders")]
    public class AmznCreateFulfillmentOrderRequest : BaseHttpRequest
    {
        /// <summary>
        /// CreateFulfillmentOrderRequest parameter
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public CreateFulfillmentOrderRequest Body { get; set; }
    }
}
