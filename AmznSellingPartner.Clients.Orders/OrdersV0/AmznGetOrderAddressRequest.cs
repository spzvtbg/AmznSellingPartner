namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/orders/v0/orders/{orderId}/address")]
    public class AmznGetOrderAddressRequest : BaseHttpRequest
    {
        /// <summary>
        /// An `orderId` is an Amazon-defined order identifier, in 3-7-7 format.
        /// </summary>
        [InPath("orderId")]
        [IsRequired]
        public string OrderId { get; set; }
    }
}
