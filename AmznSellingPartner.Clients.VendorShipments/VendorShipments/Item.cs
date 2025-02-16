namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Details of the item being shipped.
    /// </summary>
    public class Item : BaseClass
    {
        /// <summary>
        /// Item sequence number for the item. The first item will be 001, the second 002, and so on. This
        /// number is used as a reference to refer to this item from the carton or pallet level.
        /// </summary>
        [JsonProperty("itemSequenceNumber")]
        [IsRequired]
        public string ItemSequenceNumber { get; set; }

        /// <summary>
        /// Buyer Standard Identification Number (ASIN) of an item.
        /// </summary>
        [JsonProperty("amazonProductIdentifier")]
        public string AmazonProductIdentifier { get; set; }

        /// <summary>
        /// The vendor selected product identification of the item. Should be the same as was sent in the
        /// purchase order.
        /// </summary>
        [JsonProperty("vendorProductIdentifier")]
        public string VendorProductIdentifier { get; set; }

        /// <summary>
        /// Total item quantity shipped in this shipment.
        /// </summary>
        [JsonProperty("shippedQuantity")]
        [IsRequired]
        public ItemQuantity ShippedQuantity { get; set; }

        [JsonProperty("itemDetails")]
        public ItemDetails ItemDetails { get; set; }
    }
}
