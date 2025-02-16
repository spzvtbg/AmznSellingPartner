namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPut("/fba/outbound/2020-07-01/fulfillmentOrders/{sellerFulfillmentOrderId}/status")]
    public class AmznSubmitFulfillmentOrderStatusUpdateRequest : BaseHttpRequest
    {
        /// <summary>
        /// The identifier assigned to the item by the seller when the fulfillment order was created.
        /// </summary>
        [InPath("sellerFulfillmentOrderId")]
        [IsRequired]
        [MaxLength(40)]
        public string SellerFulfillmentOrderId { get; set; }

        /// <summary>
        /// The identifier assigned to the item by the seller when the fulfillment order was created.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public SubmitFulfillmentOrderStatusUpdateRequest Body { get; set; }
    }
}
