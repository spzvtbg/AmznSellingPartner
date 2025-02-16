namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/orders/v0/orders/{orderId}/orderItems/buyerInfo")]
    public class AmznGetOrderItemsBuyerInfoRequest : BaseHttpRequest
    {
        /// <summary>
        /// An Amazon-defined order identifier, in 3-7-7 format.
        /// </summary>
        [InPath("orderId")]
        [IsRequired]
        public string OrderId { get; set; }

        /// <summary>
        /// A string token returned in the response of your previous request.
        /// </summary>
        [InQuery("NextToken")]
        public string NextToken { get; set; }
    }
}
