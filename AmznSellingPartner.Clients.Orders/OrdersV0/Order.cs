namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Order information.
    /// </summary>
    public class Order : BaseClass
    {
        /// <summary>
        /// An Amazon-defined order identifier, in 3-7-7 format.
        /// </summary>
        [JsonProperty("AmazonOrderId")]
        [IsRequired]
        public string AmazonOrderId { get; set; }

        /// <summary>
        /// A seller-defined order identifier.
        /// </summary>
        [JsonProperty("SellerOrderId")]
        public string SellerOrderId { get; set; }

        /// <summary>
        /// The date when the order was created.
        /// </summary>
        [JsonProperty("PurchaseDate")]
        [IsRequired]
        public string PurchaseDate { get; set; }

        /// <summary>
        /// The date when the order was last updated.  __Note__: `LastUpdateDate` is returned with an incorrect
        /// date for orders that were last updated before 2009-04-01.
        /// </summary>
        [JsonProperty("LastUpdateDate")]
        [IsRequired]
        public string LastUpdateDate { get; set; }

        /// <summary>
        /// The current order status.
        /// </summary>
        [JsonProperty("OrderStatus")]
        [IsRequired]
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Whether the order was fulfilled by Amazon (`AFN`) or by the seller (`MFN`).
        /// </summary>
        [JsonProperty("FulfillmentChannel")]
        public FulfillmentChannel FulfillmentChannel { get; set; }

        /// <summary>
        /// The sales channel for the first item in the order.
        /// </summary>
        [JsonProperty("SalesChannel")]
        public string SalesChannel { get; set; }

        /// <summary>
        /// The order channel for the first item in the order.
        /// </summary>
        [JsonProperty("OrderChannel")]
        public string OrderChannel { get; set; }

        /// <summary>
        /// The order's shipment service level.
        /// </summary>
        [JsonProperty("ShipServiceLevel")]
        public string ShipServiceLevel { get; set; }

        /// <summary>
        /// The total charge for this order.
        /// </summary>
        [JsonProperty("OrderTotal")]
        public Money OrderTotal { get; set; }

        /// <summary>
        /// The number of items shipped.
        /// </summary>
        [JsonProperty("NumberOfItemsShipped")]
        public int NumberOfItemsShipped { get; set; }

        /// <summary>
        /// The number of items unshipped.
        /// </summary>
        [JsonProperty("NumberOfItemsUnshipped")]
        public int NumberOfItemsUnshipped { get; set; }

        /// <summary>
        /// Information about sub-payment methods for a cash-on-delivery (COD) order.  __Note__: For a
        /// COD order that is paid for using one sub-payment method, one `PaymentExecutionDetailItem` object
        /// is returned, with `PaymentExecutionDetailItem`/`PaymentMethod = COD`. For a COD order that
        /// is paid for using multiple sub-payment methods, two or more `PaymentExecutionDetailItem` objects
        /// are returned.
        /// </summary>
        [JsonProperty("PaymentExecutionDetail")]
        public PaymentExecutionDetailItemList PaymentExecutionDetail { get; set; }

        /// <summary>
        /// The payment method for the order. This property is limited to COD and CVS payment methods.
        /// Unless you need the specific COD payment information provided by the `PaymentExecutionDetailItem`
        /// object, we recommend using the `PaymentMethodDetails` property to get payment method infor
        /// mation.
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// A list of payment methods for the order.
        /// </summary>
        [JsonProperty("PaymentMethodDetails")]
        public PaymentMethodDetailItemList PaymentMethodDetails { get; set; }

        /// <summary>
        /// The identifier for the marketplace where the order was placed.
        /// </summary>
        [JsonProperty("MarketplaceId")]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// The shipment service level category for the order.  **Possible values**: `Expedited`, `FreeEconomy`,
        /// `NextDay`, `Priority`, `SameDay`, `SecondDay`, `Scheduled`, and `Standard`.
        /// </summary>
        [JsonProperty("ShipmentServiceLevelCategory")]
        public string ShipmentServiceLevelCategory { get; set; }

        /// <summary>
        /// The status of the Amazon Easy Ship order. This property is only included for Amazon Easy Ship
        /// orders.
        /// </summary>
        [JsonProperty("EasyShipShipmentStatus")]
        public EasyShipShipmentStatus EasyShipShipmentStatus { get; set; }

        /// <summary>
        /// Custom ship label for Checkout by Amazon (CBA).
        /// </summary>
        [JsonProperty("CbaDisplayableShippingLabel")]
        public string CbaDisplayableShippingLabel { get; set; }

        /// <summary>
        /// The order's type.
        /// </summary>
        [JsonProperty("OrderType")]
        public OrderType OrderType { get; set; }

        /// <summary>
        /// The start of the time period within which you have committed to ship the order. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
        /// date time format. Only returned for seller-fulfilled orders.  __Note__: `EarliestShipDate`
        /// might not be returned for orders placed before February 1, 2013.
        /// </summary>
        [JsonProperty("EarliestShipDate")]
        public string EarliestShipDate { get; set; }

        /// <summary>
        /// The end of the time period within which you have committed to ship the order. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
        /// date time format. Only returned for seller-fulfilled orders.  __Note__: `LatestShipDate` might
        /// not be returned for orders placed before February 1, 2013.
        /// </summary>
        [JsonProperty("LatestShipDate")]
        public string LatestShipDate { get; set; }

        /// <summary>
        /// The start of the time period within which you have committed to fulfill the order. In [ISO
        /// 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date time format. Only returned
        /// for seller-fulfilled orders.
        /// </summary>
        [JsonProperty("EarliestDeliveryDate")]
        public string EarliestDeliveryDate { get; set; }

        /// <summary>
        /// The end of the time period within which you have committed to fulfill the order. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
        /// date time format. Only returned for seller-fulfilled orders that do not have a `PendingAvailability`,
        /// `Pending`, or `Canceled` status.
        /// </summary>
        [JsonProperty("LatestDeliveryDate")]
        public string LatestDeliveryDate { get; set; }

        /// <summary>
        /// When true, the order is an Amazon Business order. An Amazon Business order is an order where
        /// the buyer is a Verified Business Buyer.
        /// </summary>
        [JsonProperty("IsBusinessOrder")]
        public bool IsBusinessOrder { get; set; }

        /// <summary>
        /// When true, the order is a seller-fulfilled Amazon Prime order.
        /// </summary>
        [JsonProperty("IsPrime")]
        public bool IsPrime { get; set; }

        /// <summary>
        /// When true, the order has a Premium Shipping Service Level Agreement. For more information about
        /// Premium Shipping orders, refer to "Premium Shipping Options" in the Seller Central Help for
        /// your marketplace.
        /// </summary>
        [JsonProperty("IsPremiumOrder")]
        public bool IsPremiumOrder { get; set; }

        /// <summary>
        /// When true, the order is a `GlobalExpress` order.
        /// </summary>
        [JsonProperty("IsGlobalExpressEnabled")]
        public bool IsGlobalExpressEnabled { get; set; }

        /// <summary>
        /// The order ID value for the order that is being replaced. Returned only if IsReplacementOrder
        /// = true.
        /// </summary>
        [JsonProperty("ReplacedOrderId")]
        public string ReplacedOrderId { get; set; }

        /// <summary>
        /// When true, this is a replacement order.
        /// </summary>
        [JsonProperty("IsReplacementOrder")]
        public bool IsReplacementOrder { get; set; }

        /// <summary>
        /// Indicates the date by which the seller must respond to the buyer with an estimated ship date.
        /// Only returned for Sourcing on Demand orders.
        /// </summary>
        [JsonProperty("PromiseResponseDueDate")]
        public string PromiseResponseDueDate { get; set; }

        /// <summary>
        /// When true, the estimated ship date is set for the order. Only returned for Sourcing on Demand
        /// orders.
        /// </summary>
        [JsonProperty("IsEstimatedShipDateSet")]
        public bool IsEstimatedShipDateSet { get; set; }

        /// <summary>
        /// When true, the item within this order was bought and re-sold by Amazon Business EU SARL (ABEU).
        /// By buying and instantly re-selling your items, ABEU becomes the seller of record, making your
        /// inventory available for sale to customers who would not otherwise purchase from a third-party
        /// seller.
        /// </summary>
        [JsonProperty("IsSoldByAB")]
        public bool IsSoldByAB { get; set; }

        /// <summary>
        /// When true, the item within this order was bought and re-sold by Amazon Business EU SARL (ABEU).
        /// By buying and instantly re-selling your items, ABEU becomes the seller of record, making your
        /// inventory available for sale to customers who would not otherwise purchase from a third-party
        /// seller.
        /// </summary>
        [JsonProperty("IsIBA")]
        public bool IsIBA { get; set; }

        /// <summary>
        /// The recommended location for the seller to ship the items from. It is calculated at checkout.
        /// The seller may or may not choose to ship from this location.
        /// </summary>
        [JsonProperty("DefaultShipFromLocationAddress")]
        public Address DefaultShipFromLocationAddress { get; set; }

        /// <summary>
        /// The buyer's invoicing preference. Sellers can use this data to issue electronic invoices for
        /// orders in Turkey.  **Note**: This attribute is only available in the Turkey marketplace.
        /// </summary>
        [JsonProperty("BuyerInvoicePreference")]
        public BuyerInvoicePreference BuyerInvoicePreference { get; set; }

        /// <summary>
        /// Contains the business invoice tax information. Sellers could use this data to issue electronic
        /// invoices for business orders in Turkey.  **Note**: 1. This attribute is only available in the
        /// Turkey marketplace for the orders that `BuyerInvoicePreference` is BUSINESS. 2. The `BuyerTaxInformation`
        /// is a restricted data. Use the Restricted Data Token (RDT) and restricted SPDS roles to access
        /// this restricted data.
        /// </summary>
        [JsonProperty("BuyerTaxInformation")]
        public BuyerTaxInformation BuyerTaxInformation { get; set; }

        /// <summary>
        /// Contains the instructions about the fulfillment, such as the location from where you want the
        /// order filled.
        /// </summary>
        [JsonProperty("FulfillmentInstruction")]
        public FulfillmentInstruction FulfillmentInstruction { get; set; }

        /// <summary>
        /// When true, this order is marked to be picked up from a store rather than delivered.
        /// </summary>
        [JsonProperty("IsISPU")]
        public bool IsISPU { get; set; }

        /// <summary>
        /// When true, this order is marked to be delivered to an Access Point. The access location is
        /// chosen by the customer. Access Points include Amazon Hub Lockers, Amazon Hub Counters, and
        /// pickup points operated by carriers.
        /// </summary>
        [JsonProperty("IsAccessPointOrder")]
        public bool IsAccessPointOrder { get; set; }

        /// <summary>
        /// Tax information about the marketplace where the sale took place. Sellers can use this data
        /// to issue electronic invoices for orders in Brazil.  **Note**: This attribute is only available
        /// in the Brazil marketplace for the orders with `Pending` or `Unshipped` status.
        /// </summary>
        [JsonProperty("MarketplaceTaxInfo")]
        public MarketplaceTaxInfo MarketplaceTaxInfo { get; set; }

        /// <summary>
        /// The seller’s friendly name registered in the marketplace where the sale took place. Sellers
        /// can use this data to issue electronic invoices for orders in Brazil.  **Note**: This attribute
        /// is only available in the Brazil marketplace for the orders with `Pending` or `Unshipped` s
        /// tatus.
        /// </summary>
        [JsonProperty("SellerDisplayName")]
        public string SellerDisplayName { get; set; }

        /// <summary>
        /// The shipping address for the order.  **Note**: 1. `ShippingAddress` is only available for orders
        /// with the following status values: Unshipped, `PartiallyShipped`, Shipped and `InvoiceUnconfirmed`.
        /// 2. The `ShippingAddress` contains restricted data. Use the Restricted Data Token (RDT) and
        /// restricted SPDS roles to access the restricted data in `ShippingAddress`. For example, `Name`,
        /// `AddressLine1`, `AddressLine2`, `AddressLine3`, `Phone`, `AddressType`, and `ExtendedField
        /// s`.
        /// </summary>
        [JsonProperty("ShippingAddress")]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Buyer information.  **Note**: The `BuyerInfo` contains restricted data. Use the Restricted
        /// Data Token (RDT) and restricted SPDS roles to access the restricted data in `BuyerInfo`. For
        /// example, `BuyerName`, `BuyerTaxInfo`, and `PurchaseOrderNumber`.
        /// </summary>
        [JsonProperty("BuyerInfo")]
        public BuyerInfo BuyerInfo { get; set; }

        /// <summary>
        /// Contains information regarding the Shipping Settings Automaton program, such as whether the
        /// order's shipping settings were generated automatically, and what those settings are.
        /// </summary>
        [JsonProperty("AutomatedShippingSettings")]
        public AutomatedShippingSettings AutomatedShippingSettings { get; set; }

        /// <summary>
        /// Whether the order contains regulated items which may require additional approval steps before
        /// being fulfilled.
        /// </summary>
        [JsonProperty("HasRegulatedItems")]
        public bool HasRegulatedItems { get; set; }

        /// <summary>
        /// The status of the electronic invoice.
        /// </summary>
        [JsonProperty("ElectronicInvoiceStatus")]
        public ElectronicInvoiceStatus ElectronicInvoiceStatus { get; set; }
    }
}
