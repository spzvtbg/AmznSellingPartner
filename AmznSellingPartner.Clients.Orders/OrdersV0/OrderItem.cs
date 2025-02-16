namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// A single order item.
    /// </summary>
    public class OrderItem : BaseClass
    {
        /// <summary>
        /// The item's Amazon Standard Identification Number (ASIN).
        /// </summary>
        [JsonProperty("ASIN")]
        [IsRequired]
        public string ASIN { get; set; }

        /// <summary>
        /// The item's seller stock keeping unit (SKU).
        /// </summary>
        [JsonProperty("SellerSKU")]
        public string SellerSKU { get; set; }

        /// <summary>
        /// An Amazon-defined order item identifier.
        /// </summary>
        [JsonProperty("OrderItemId")]
        [IsRequired]
        public string OrderItemId { get; set; }

        /// <summary>
        /// A list of associated items that a customer has purchased with a product. For example, a tire
        /// installation service purchased with tires.
        /// </summary>
        [JsonProperty("AssociatedItems")]
        public List<AssociatedItem> AssociatedItems { get; set; }

        /// <summary>
        /// The item's name.
        /// </summary>
        [JsonProperty("Title")]
        public string Title { get; set; }

        /// <summary>
        /// The number of items in the order.
        /// </summary>
        [JsonProperty("QuantityOrdered")]
        [IsRequired]
        public int QuantityOrdered { get; set; }

        /// <summary>
        /// The number of items shipped.
        /// </summary>
        [JsonProperty("QuantityShipped")]
        public int QuantityShipped { get; set; }

        /// <summary>
        /// The item's product information.
        /// </summary>
        [JsonProperty("ProductInfo")]
        public ProductInfoDetail ProductInfo { get; set; }

        /// <summary>
        /// The number and value of Amazon Points granted with the purchase of an item.
        /// </summary>
        [JsonProperty("PointsGranted")]
        public PointsGrantedDetail PointsGranted { get; set; }

        /// <summary>
        /// The selling price of the order item. Note that an order item is an item and a quantity. This
        /// means that the value of `ItemPrice` is equal to the selling price of the item multiplied by
        /// the quantity ordered. `ItemPrice` excludes `ShippingPrice` and GiftWrapPrice.
        /// </summary>
        [JsonProperty("ItemPrice")]
        public Money ItemPrice { get; set; }

        /// <summary>
        /// The item's shipping price.
        /// </summary>
        [JsonProperty("ShippingPrice")]
        public Money ShippingPrice { get; set; }

        /// <summary>
        /// The tax on the item price.
        /// </summary>
        [JsonProperty("ItemTax")]
        public Money ItemTax { get; set; }

        /// <summary>
        /// The tax on the shipping price.
        /// </summary>
        [JsonProperty("ShippingTax")]
        public Money ShippingTax { get; set; }

        /// <summary>
        /// The discount on the shipping price.
        /// </summary>
        [JsonProperty("ShippingDiscount")]
        public Money ShippingDiscount { get; set; }

        /// <summary>
        /// The tax on the discount on the shipping price.
        /// </summary>
        [JsonProperty("ShippingDiscountTax")]
        public Money ShippingDiscountTax { get; set; }

        /// <summary>
        /// The total of all promotional discounts in the offer.
        /// </summary>
        [JsonProperty("PromotionDiscount")]
        public Money PromotionDiscount { get; set; }

        /// <summary>
        /// The tax on the total of all promotional discounts in the offer.
        /// </summary>
        [JsonProperty("PromotionDiscountTax")]
        public Money PromotionDiscountTax { get; set; }

        [JsonProperty("PromotionIds")]
        public PromotionIdList PromotionIds { get; set; }

        /// <summary>
        /// The fee charged for COD service.
        /// </summary>
        [JsonProperty("CODFee")]
        public Money CODFee { get; set; }

        /// <summary>
        /// The discount on the COD fee.
        /// </summary>
        [JsonProperty("CODFeeDiscount")]
        public Money CODFeeDiscount { get; set; }

        /// <summary>
        /// Indicates whether the item is a gift.  **Possible values**: `true` and `false`.
        /// </summary>
        [JsonProperty("IsGift")]
        public string IsGift { get; set; }

        /// <summary>
        /// The condition of the item, as described by the seller.
        /// </summary>
        [JsonProperty("ConditionNote")]
        public string ConditionNote { get; set; }

        /// <summary>
        /// The condition of the item.  **Possible values**: `New`, `Used`, `Collectible`, `Refurbished`,
        /// `Preorder`, and `Club`.
        /// </summary>
        [JsonProperty("ConditionId")]
        public string ConditionId { get; set; }

        /// <summary>
        /// The subcondition of the item.  **Possible values**: `New`, `Mint`, `Very Good`, `Good`, `Acceptable`,
        /// `Poor`, `Club`, `OEM`, `Warranty`, `Refurbished Warranty`, `Refurbished`, `Open Box`, `Any`,
        /// and `Other`.
        /// </summary>
        [JsonProperty("ConditionSubtypeId")]
        public string ConditionSubtypeId { get; set; }

        /// <summary>
        /// The start date of the scheduled delivery window in the time zone for the order destination.
        /// In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date time format.
        /// </summary>
        [JsonProperty("ScheduledDeliveryStartDate")]
        public string ScheduledDeliveryStartDate { get; set; }

        /// <summary>
        /// The end date of the scheduled delivery window in the time zone for the order destination. In
        /// [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date time format.
        /// </summary>
        [JsonProperty("ScheduledDeliveryEndDate")]
        public string ScheduledDeliveryEndDate { get; set; }

        /// <summary>
        /// Indicates that the selling price is a special price that is only available for Amazon Business
        /// orders. For more information about the Amazon Business Seller Program, refer to the [Amazon
        /// Business website](https://www.amazon.com/b2b/info/amazon-business).   **Possible values**:
        /// `BusinessPrice`
        /// </summary>
        [JsonProperty("PriceDesignation")]
        public string PriceDesignation { get; set; }

        /// <summary>
        /// Information about withheld taxes.
        /// </summary>
        [JsonProperty("TaxCollection")]
        public TaxCollection TaxCollection { get; set; }

        /// <summary>
        /// When true, the product type for this item has a serial number.   Only returned for Amazon Easy
        /// Ship orders.
        /// </summary>
        [JsonProperty("SerialNumberRequired")]
        public bool SerialNumberRequired { get; set; }

        /// <summary>
        /// When true, the ASIN is enrolled in Transparency. The Transparency serial number that you must
        /// submit is determined by:  **1D or 2D Barcode:** This has a **T** logo. Submit either the 29-character
        /// alpha-numeric identifier beginning with **AZ** or **ZA**, or the 38-character Serialized Global
        /// Trade Item Number (SGTIN). **2D Barcode SN:** Submit the 7- to 20-character serial number barcode,
        /// which likely has the prefix **SN**. The serial number is applied to the same side of the packaging
        /// as the GTIN (UPC/EAN/ISBN) barcode. **QR code SN:** Submit the URL that the QR code genera
        /// tes.
        /// </summary>
        [JsonProperty("IsTransparency")]
        public bool IsTransparency { get; set; }

        /// <summary>
        /// The IOSS number of the marketplace. Sellers shipping to the EU from outside the EU must provide
        /// this IOSS number to their carrier when Amazon has collected the VAT on the sale.
        /// </summary>
        [JsonProperty("IossNumber")]
        public string IossNumber { get; set; }

        /// <summary>
        /// The store chain store identifier. Linked to a specific store in a store chain.
        /// </summary>
        [JsonProperty("StoreChainStoreId")]
        public string StoreChainStoreId { get; set; }

        /// <summary>
        /// The category of deemed reseller. This applies to selling partners that are not based in the
        /// EU and is used to help them meet the VAT Deemed Reseller tax laws in the EU and UK.
        /// </summary>
        [JsonProperty("DeemedResellerCategory")]
        public DeemedResellerCategory DeemedResellerCategory { get; set; }

        /// <summary>
        /// A single item's buyer information.  **Note**: The `BuyerInfo` contains restricted data. Use
        /// the Restricted Data Token (RDT) and restricted SPDS roles to access the restricted data in
        /// `BuyerInfo`. For example, `BuyerCustomizedInfo` and `GiftMessageText`.
        /// </summary>
        [JsonProperty("BuyerInfo")]
        public ItemBuyerInfo BuyerInfo { get; set; }

        /// <summary>
        /// Information about whether or not a buyer requested cancellation.
        /// </summary>
        [JsonProperty("BuyerRequestedCancel")]
        public BuyerRequestedCancel BuyerRequestedCancel { get; set; }

        /// <summary>
        /// A list of serial numbers for electronic products that are shipped to customers. Returned for
        /// FBA orders only.
        /// </summary>
        [JsonProperty("SerialNumbers")]
        public List<string> SerialNumbers { get; set; }

        /// <summary>
        /// Substitution preferences for the order item. This is an optional field that is only present
        /// if a seller supports substitutions, as is the case with some grocery sellers.
        /// </summary>
        [JsonProperty("SubstitutionPreferences")]
        public SubstitutionPreferences SubstitutionPreferences { get; set; }

        /// <summary>
        /// Measurement information for the order item.
        /// </summary>
        [JsonProperty("Measurement")]
        public Measurement Measurement { get; set; }

        /// <summary>
        /// Shipping constraints applicable to this order.
        /// </summary>
        [JsonProperty("ShippingConstraints")]
        public ShippingConstraints ShippingConstraints { get; set; }

        /// <summary>
        /// Contains the list of programs that are associated with an item.
        /// </summary>
        [JsonProperty("AmazonPrograms")]
        public AmazonPrograms AmazonPrograms { get; set; }
    }
}
