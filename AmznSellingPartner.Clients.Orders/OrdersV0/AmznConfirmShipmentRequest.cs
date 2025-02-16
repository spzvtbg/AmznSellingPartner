namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/orders/v0/orders/{orderId}/shipmentConfirmation")]
    public class AmznConfirmShipmentRequest : BaseHttpRequest
    {
        /// <summary>
        /// An Amazon-defined order identifier, in 3-7-7 format.
        /// </summary>
        [InPath("orderId")]
        [IsRequired]
        public string OrderId { get; set; }

        /// <summary>
        /// Request body of `confirmShipment`.
        /// </summary>
        [InBody("payload")]
        [IsRequired]
        public ConfirmShipmentRequest Payload { get; set; }
    }
}
