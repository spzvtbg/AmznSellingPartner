namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Item information for creating a fulfillment order.
    /// </summary>
    public class CreateFulfillmentOrderItem : BaseClass
    {
        /// <summary>
        /// The seller SKU of the item.
        /// </summary>
        [JsonProperty("sellerSku")]
        [IsRequired]
        [MaxLength(50)]
        public string SellerSku { get; set; }

        /// <summary>
        /// A fulfillment order item identifier that the seller creates to track fulfillment order items.
        /// Used to disambiguate multiple fulfillment items that have the same `SellerSKU`. For example,
        /// the seller might assign different `SellerFulfillmentOrderItemId` values to two items in a fulfillment
        /// order that share the same `SellerSKU` but have different `GiftMessage` values.
        /// </summary>
        [JsonProperty("sellerFulfillmentOrderItemId")]
        [IsRequired]
        [MaxLength(50)]
        public string SellerFulfillmentOrderItemId { get; set; }

        [JsonProperty("quantity")]
        [IsRequired]
        public Quantity Quantity { get; set; }

        /// <summary>
        /// A message to the gift recipient, if applicable.
        /// </summary>
        [JsonProperty("giftMessage")]
        [MaxLength(512)]
        public string GiftMessage { get; set; }

        /// <summary>
        /// Item-specific text that displays in recipient-facing materials such as the outbound shipment
        /// packing slip.
        /// </summary>
        [JsonProperty("displayableComment")]
        [MaxLength(250)]
        public string DisplayableComment { get; set; }

        /// <summary>
        /// Amazon's fulfillment network SKU of the item.
        /// </summary>
        [JsonProperty("fulfillmentNetworkSku")]
        public string FulfillmentNetworkSku { get; set; }

        /// <summary>
        /// The monetary value assigned by the seller to this item. This is a required field for India
        /// MCF orders.
        /// </summary>
        [JsonProperty("perUnitDeclaredValue")]
        public Money PerUnitDeclaredValue { get; set; }

        /// <summary>
        /// The amount to be collected from the recipient for this item in a COD (Cash On Delivery) or
        /// der.
        /// </summary>
        [JsonProperty("perUnitPrice")]
        public Money PerUnitPrice { get; set; }

        /// <summary>
        /// The tax on the amount to be collected from the recipient for this item in a COD (Cash On Delivery)
        /// order.
        /// </summary>
        [JsonProperty("perUnitTax")]
        public Money PerUnitTax { get; set; }
    }
}
