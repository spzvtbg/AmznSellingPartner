namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    [HttpGet("/orders/v0/orders")]
    public class AmznGetOrdersRequest : BaseHttpRequest
    {
        /// <summary>
        /// Use this date to select orders created after (or at) a specified time. Only orders placed after
        /// the specified time are returned. The date must be in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
        /// format.  **Note**: Either the `CreatedAfter` parameter or the `LastUpdatedAfter` parameter
        /// is required. Both cannot be empty. `LastUpdatedAfter` and `LastUpdatedBefore` cannot be set
        /// when `CreatedAfter` is set.
        /// </summary>
        [InQuery("CreatedAfter")]
        public string CreatedAfter { get; set; }

        /// <summary>
        /// Use this date to select orders created before (or at) a specified time. Only orders placed
        /// before the specified time are returned. The date must be in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
        /// format.  **Note**: `CreatedBefore` is optional when `CreatedAfter` is set. If specified, `CreatedBefore`
        /// must be equal to or after the `CreatedAfter` date and at least two minutes before current
        /// time.
        /// </summary>
        [InQuery("CreatedBefore")]
        public string CreatedBefore { get; set; }

        /// <summary>
        /// Use this date to select orders that were last updated after (or at) a specified time. An update
        /// is defined as any change in order status, including the creation of a new order. Includes updates
        /// made by Amazon and by the seller. The date must be in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
        /// format.  **Note**: Either the `CreatedAfter` parameter or the `LastUpdatedAfter` parameter
        /// is required. Both cannot be empty. `CreatedAfter` or `CreatedBefore` cannot be set when `LastUpdatedAfter`
        /// is set.
        /// </summary>
        [InQuery("LastUpdatedAfter")]
        public string LastUpdatedAfter { get; set; }

        /// <summary>
        /// Use this date to select orders that were last updated before (or at) a specified time. An update
        /// is defined as any change in order status, including the creation of a new order. Includes updates
        /// made by Amazon and by the seller. The date must be in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
        /// format.  **Note**: `LastUpdatedBefore` is optional when `LastUpdatedAfter` is set. But if specified,
        /// `LastUpdatedBefore` must be equal to or after the `LastUpdatedAfter` date and at least two
        /// minutes before current time.
        /// </summary>
        [InQuery("LastUpdatedBefore")]
        public string LastUpdatedBefore { get; set; }

        /// <summary>
        /// A list of `OrderStatus` values used to filter the results.  **Possible values:** - `PendingAvailability`
        /// (This status is available for pre-orders only. The order has been placed, payment has not been
        /// authorized, and the release date of the item is in the future.) - `Pending` (The order has
        /// been placed but payment has not been authorized.) - `Unshipped` (Payment has been authorized
        /// and the order is ready for shipment, but no items in the order have been shipped.) - `PartiallyShipped`
        /// (One or more, but not all, items in the order have been shipped.) - `Shipped` (All items in
        /// the order have been shipped.) - `InvoiceUnconfirmed` (All items in the order have been shipped.
        /// The seller has not yet given confirmation to Amazon that the invoice has been shipped to the
        /// buyer.) - `Canceled` (The order has been canceled.) - `Unfulfillable` (The order cannot be
        /// fulfilled. This state applies only to Multi-Channel Fulfillment orders.)
        /// </summary>
        [InQuery("OrderStatuses")]
        public CsvValue<string> OrderStatuses { get; set; }

        /// <summary>
        /// A list of `MarketplaceId` values. Used to select orders that were placed in the specified marketplaces.
        /// Refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids) for
        /// a complete list of `marketplaceId` values.
        /// </summary>
        [InQuery("MarketplaceIds")]
        [IsRequired]
        [MaxItems(50)]
        public CsvValue<string> MarketplaceIds { get; set; }

        /// <summary>
        /// A list that indicates how an order was fulfilled. Filters the results by fulfillment channel.
        /// **Possible values**: `AFN` (fulfilled by Amazon), `MFN` (fulfilled by seller).
        /// </summary>
        [InQuery("FulfillmentChannels")]
        public CsvValue<string> FulfillmentChannels { get; set; }

        /// <summary>
        /// A list of payment method values. Use this field to select orders that were paid with the specified
        /// payment methods.  **Possible values**: `COD` (cash on delivery), `CVS` (convenience store),
        /// `Other` (Any payment method other than COD or CVS).
        /// </summary>
        [InQuery("PaymentMethods")]
        public CsvValue<string> PaymentMethods { get; set; }

        /// <summary>
        /// The email address of a buyer. Used to select orders that contain the specified email addre
        /// ss.
        /// </summary>
        [InQuery("BuyerEmail")]
        public string BuyerEmail { get; set; }

        /// <summary>
        /// An order identifier that is specified by the seller. Used to select only the orders that match
        /// the order identifier. If `SellerOrderId` is specified, then `FulfillmentChannels`, `OrderStatuses`,
        /// `PaymentMethod`, `LastUpdatedAfter`, LastUpdatedBefore, and `BuyerEmail` cannot be specifi
        /// ed.
        /// </summary>
        [InQuery("SellerOrderId")]
        public string SellerOrderId { get; set; }

        /// <summary>
        /// A number that indicates the maximum number of orders that can be returned per page. Value must
        /// be 1 - 100. Default 100.
        /// </summary>
        [InQuery("MaxResultsPerPage")]
        public int MaxResultsPerPage { get; set; }

        /// <summary>
        /// A list of `EasyShipShipmentStatus` values. Used to select Easy Ship orders with statuses that
        /// match the specified values. If `EasyShipShipmentStatus` is specified, only Amazon Easy Ship
        /// orders are returned.  **Possible values:** - `PendingSchedule` (The package is awaiting the
        /// schedule for pick-up.) - `PendingPickUp` (Amazon has not yet picked up the package from the
        /// seller.) - `PendingDropOff` (The seller will deliver the package to the carrier.) - `LabelCanceled`
        /// (The seller canceled the pickup.) - `PickedUp` (Amazon has picked up the package from the seller.)
        /// - `DroppedOff` (The package is delivered to the carrier by the seller.) - `AtOriginFC` (The
        /// packaged is at the origin fulfillment center.) - `AtDestinationFC` (The package is at the destination
        /// fulfillment center.) - `Delivered` (The package has been delivered.) - `RejectedByBuyer` (The
        /// package has been rejected by the buyer.) - `Undeliverable` (The package cannot be delivered.)
        /// - `ReturningToSeller` (The package was not delivered and is being returned to the seller.)
        /// - `ReturnedToSeller` (The package was not delivered and was returned to the seller.) - `Lost`
        /// (The package is lost.) - `OutForDelivery` (The package is out for delivery.) - `Damaged` (The
        /// package was damaged by the carrier.)
        /// </summary>
        [InQuery("EasyShipShipmentStatuses")]
        public CsvValue<string> EasyShipShipmentStatuses { get; set; }

        /// <summary>
        /// A list of `ElectronicInvoiceStatus` values. Used to select orders with electronic invoice statuses
        /// that match the specified values.  **Possible values:** - `NotRequired` (Electronic invoice
        /// submission is not required for this order.) - `NotFound` (The electronic invoice was not submitted
        /// for this order.) - `Processing` (The electronic invoice is being processed for this order.)
        /// - `Errored` (The last submitted electronic invoice was rejected for this order.) - `Accepted`
        /// (The last submitted electronic invoice was submitted and accepted.)
        /// </summary>
        [InQuery("ElectronicInvoiceStatuses")]
        public CsvValue<string> ElectronicInvoiceStatuses { get; set; }

        /// <summary>
        /// A string token returned in the response of your previous request.
        /// </summary>
        [InQuery("NextToken")]
        public string NextToken { get; set; }

        /// <summary>
        /// A list of `AmazonOrderId` values. An `AmazonOrderId` is an Amazon-defined order identifier,
        /// in 3-7-7 format.
        /// </summary>
        [InQuery("AmazonOrderIds")]
        [MaxItems(50)]
        public CsvValue<string> AmazonOrderIds { get; set; }

        /// <summary>
        /// The `sourceId` of the location from where you want the order fulfilled.
        /// </summary>
        [InQuery("ActualFulfillmentSupplySourceId")]
        public string ActualFulfillmentSupplySourceId { get; set; }

        /// <summary>
        /// When true, this order is marked to be picked up from a store rather than delivered.
        /// </summary>
        [InQuery("IsISPU")]
        public bool IsISPU { get; set; }

        /// <summary>
        /// The store chain store identifier. Linked to a specific store in a store chain.
        /// </summary>
        [InQuery("StoreChainStoreId")]
        public string StoreChainStoreId { get; set; }

        /// <summary>
        /// Use this date to select orders with a earliest delivery date before (or at) a specified time.
        /// The date must be in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) for
        /// mat.
        /// </summary>
        [InQuery("EarliestDeliveryDateBefore")]
        public string EarliestDeliveryDateBefore { get; set; }

        /// <summary>
        /// Use this date to select orders with a earliest delivery date after (or at) a specified time.
        /// The date must be in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) for
        /// mat.
        /// </summary>
        [InQuery("EarliestDeliveryDateAfter")]
        public string EarliestDeliveryDateAfter { get; set; }

        /// <summary>
        /// Use this date to select orders with a latest delivery date before (or at) a specified time.
        /// The date must be in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) for
        /// mat.
        /// </summary>
        [InQuery("LatestDeliveryDateBefore")]
        public string LatestDeliveryDateBefore { get; set; }

        /// <summary>
        /// Use this date to select orders with a latest delivery date after (or at) a specified time.
        /// The date must be in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) for
        /// mat.
        /// </summary>
        [InQuery("LatestDeliveryDateAfter")]
        public string LatestDeliveryDateAfter { get; set; }
    }
}
