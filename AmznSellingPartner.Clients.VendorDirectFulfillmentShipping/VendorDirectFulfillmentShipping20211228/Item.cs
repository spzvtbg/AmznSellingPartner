namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Details of the item being shipped.
    /// </summary>
    public class Item : BaseClass
    {
        /// <summary>
        /// The sequence number of the item. The number must be the same as the order number of the it
        /// em.
        /// </summary>
        [JsonProperty("itemSequenceNumber")]
        [IsRequired]
        public int ItemSequenceNumber { get; set; }

        /// <summary>
        /// The buyer's Amazon Standard Identification Number (ASIN) of an item. Either `buyerProductIdentifier`
        /// or `vendorProductIdentifier` is required.
        /// </summary>
        [JsonProperty("buyerProductIdentifier")]
        public string BuyerProductIdentifier { get; set; }

        /// <summary>
        /// An item's product identifier, which the vendor selects. This identifier should be the same
        /// as the identifier, such as a SKU, in the purchase order.
        /// </summary>
        [JsonProperty("vendorProductIdentifier")]
        public string VendorProductIdentifier { get; set; }

        /// <summary>
        /// The total quantity of items that are in this shipment.
        /// </summary>
        [JsonProperty("shippedQuantity")]
        [IsRequired]
        public ItemQuantity ShippedQuantity { get; set; }
    }
}
