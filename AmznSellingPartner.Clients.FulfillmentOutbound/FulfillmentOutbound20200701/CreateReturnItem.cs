namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// An item that Amazon accepted for return.
    /// </summary>
    public class CreateReturnItem : BaseClass
    {
        /// <summary>
        /// An identifier assigned by the seller to the return item.
        /// </summary>
        [JsonProperty("sellerReturnItemId")]
        [IsRequired]
        [MaxLength(80)]
        public string SellerReturnItemId { get; set; }

        /// <summary>
        /// The identifier assigned to the item by the seller when the fulfillment order was created.
        /// </summary>
        [JsonProperty("sellerFulfillmentOrderItemId")]
        [IsRequired]
        public string SellerFulfillmentOrderItemId { get; set; }

        /// <summary>
        /// The identifier for the shipment that is associated with the return item.
        /// </summary>
        [JsonProperty("amazonShipmentId")]
        [IsRequired]
        public string AmazonShipmentId { get; set; }

        /// <summary>
        /// The return reason code assigned to the return item by the seller.
        /// </summary>
        [JsonProperty("returnReasonCode")]
        [IsRequired]
        public string ReturnReasonCode { get; set; }

        /// <summary>
        /// An optional comment about the return item.
        /// </summary>
        [JsonProperty("returnComment")]
        [MaxLength(1000)]
        public string ReturnComment { get; set; }
    }
}
