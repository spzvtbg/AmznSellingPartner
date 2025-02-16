namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPut("/fba/outbound/2020-07-01/fulfillmentOrders/{sellerFulfillmentOrderId}")]
    public class AmznUpdateFulfillmentOrderRequest : BaseHttpRequest
    {
        /// <summary>
        /// UpdateFulfillmentOrderRequest parameter
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public UpdateFulfillmentOrderRequest Body { get; set; }

        /// <summary>
        /// The identifier assigned to the item by the seller when the fulfillment order was created.
        /// </summary>
        [InPath("sellerFulfillmentOrderId")]
        [IsRequired]
        [MaxLength(40)]
        public string SellerFulfillmentOrderId { get; set; }
    }
}
