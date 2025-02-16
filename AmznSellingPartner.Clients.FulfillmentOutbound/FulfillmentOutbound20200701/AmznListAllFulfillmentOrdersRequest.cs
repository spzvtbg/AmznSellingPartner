namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.Values;

    [HttpGet("/fba/outbound/2020-07-01/fulfillmentOrders")]
    public class AmznListAllFulfillmentOrdersRequest : BaseHttpRequest
    {
        /// <summary>
        /// A date used to select fulfillment orders that were last updated after (or at) a specified time.
        /// An update is defined as any change in fulfillment order status, including the creation of a
        /// new fulfillment order.
        /// </summary>
        [InQuery("queryStartDate")]
        public DateTimeValue QueryStartDate { get; set; }

        /// <summary>
        /// A string token returned in the response to your previous request.
        /// </summary>
        [InQuery("nextToken")]
        public string NextToken { get; set; }
    }
}
