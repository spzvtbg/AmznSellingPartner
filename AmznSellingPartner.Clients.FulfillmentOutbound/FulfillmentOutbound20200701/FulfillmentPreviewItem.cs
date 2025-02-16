namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Item information for a shipment in a fulfillment order preview.
    /// </summary>
    public class FulfillmentPreviewItem : BaseClass
    {
        /// <summary>
        /// The seller SKU of the item.
        /// </summary>
        [JsonProperty("sellerSku")]
        [IsRequired]
        public string SellerSku { get; set; }

        /// <summary>
        /// The item quantity.
        /// </summary>
        [JsonProperty("quantity")]
        [IsRequired]
        public Quantity Quantity { get; set; }

        /// <summary>
        /// A fulfillment order item identifier that the seller created with a call to the `createFulfillmentOrder`
        /// operation.
        /// </summary>
        [JsonProperty("sellerFulfillmentOrderItemId")]
        [IsRequired]
        public string SellerFulfillmentOrderItemId { get; set; }

        /// <summary>
        /// The estimated shipping weight of the item quantity for a single item, as identified by `sellerSku`,
        /// in a shipment.
        /// </summary>
        [JsonProperty("estimatedShippingWeight")]
        public Weight EstimatedShippingWeight { get; set; }

        /// <summary>
        /// The method used to calculate the estimated shipping weight.
        /// </summary>
        [JsonProperty("shippingWeightCalculationMethod")]
        public ShippingWeightCalculationMethod ShippingWeightCalculationMethod { get; set; }
    }
}
