namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    [HttpGet("/vendor/shipping/v1/shipments")]
    public class AmznGetShipmentDetailsRequest : BaseHttpRequest
    {
        /// <summary>
        /// The limit to the number of records returned. Default value is 50 records.
        /// </summary>
        [InQuery("limit")]
        [Minimum(1)]
        [Maximum(50)]
        public long Limit { get; set; }

        /// <summary>
        /// Sort in ascending or descending order by purchase order creation date.
        /// </summary>
        [InQuery("sortOrder")]
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Used for pagination when there are more shipments than the specified result size limit.
        /// </summary>
        [InQuery("nextToken")]
        public string NextToken { get; set; }

        /// <summary>
        /// Get Shipment Details that became available after this timestamp will be included in the result.
        /// Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO 8601</a> f
        /// ormat.
        /// </summary>
        [InQuery("createdAfter")]
        public DateTimeValue CreatedAfter { get; set; }

        /// <summary>
        /// Get Shipment Details that became available before this timestamp will be included in the result.
        /// Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO 8601</a> f
        /// ormat.
        /// </summary>
        [InQuery("createdBefore")]
        public DateTimeValue CreatedBefore { get; set; }

        /// <summary>
        /// Get Shipment Details by passing Shipment confirmed create Date Before. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> format.
        /// </summary>
        [InQuery("shipmentConfirmedBefore")]
        public DateTimeValue ShipmentConfirmedBefore { get; set; }

        /// <summary>
        /// Get Shipment Details by passing Shipment confirmed create Date After. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> format.
        /// </summary>
        [InQuery("shipmentConfirmedAfter")]
        public DateTimeValue ShipmentConfirmedAfter { get; set; }

        /// <summary>
        /// Get Shipment Details by passing Package label create Date by buyer. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> format.
        /// </summary>
        [InQuery("packageLabelCreatedBefore")]
        public DateTimeValue PackageLabelCreatedBefore { get; set; }

        /// <summary>
        /// Get Shipment Details by passing Package label create Date After by buyer. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> format.
        /// </summary>
        [InQuery("packageLabelCreatedAfter")]
        public DateTimeValue PackageLabelCreatedAfter { get; set; }

        /// <summary>
        /// Get Shipment Details by passing Shipped Date Before. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> format.
        /// </summary>
        [InQuery("shippedBefore")]
        public DateTimeValue ShippedBefore { get; set; }

        /// <summary>
        /// Get Shipment Details by passing Shipped Date After. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> format.
        /// </summary>
        [InQuery("shippedAfter")]
        public DateTimeValue ShippedAfter { get; set; }

        /// <summary>
        /// Get Shipment Details by passing Estimated Delivery Date Before. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> format.
        /// </summary>
        [InQuery("estimatedDeliveryBefore")]
        public DateTimeValue EstimatedDeliveryBefore { get; set; }

        /// <summary>
        /// Get Shipment Details by passing Estimated Delivery Date Before. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> format.
        /// </summary>
        [InQuery("estimatedDeliveryAfter")]
        public DateTimeValue EstimatedDeliveryAfter { get; set; }

        /// <summary>
        /// Get Shipment Details by passing Shipment Delivery Date Before. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> format.
        /// </summary>
        [InQuery("shipmentDeliveryBefore")]
        public DateTimeValue ShipmentDeliveryBefore { get; set; }

        /// <summary>
        /// Get Shipment Details by passing Shipment Delivery Date After. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> format.
        /// </summary>
        [InQuery("shipmentDeliveryAfter")]
        public DateTimeValue ShipmentDeliveryAfter { get; set; }

        /// <summary>
        /// Get Shipment Details by passing Before Requested pickup date. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> format.
        /// </summary>
        [InQuery("requestedPickUpBefore")]
        public DateTimeValue RequestedPickUpBefore { get; set; }

        /// <summary>
        /// Get Shipment Details by passing After Requested pickup date. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> format.
        /// </summary>
        [InQuery("requestedPickUpAfter")]
        public DateTimeValue RequestedPickUpAfter { get; set; }

        /// <summary>
        /// Get Shipment Details by passing Before scheduled pickup date. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> format.
        /// </summary>
        [InQuery("scheduledPickUpBefore")]
        public DateTimeValue ScheduledPickUpBefore { get; set; }

        /// <summary>
        /// Get Shipment Details by passing After Scheduled pickup date. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> format.
        /// </summary>
        [InQuery("scheduledPickUpAfter")]
        public DateTimeValue ScheduledPickUpAfter { get; set; }

        /// <summary>
        /// Get Shipment Details by passing Current shipment status.
        /// </summary>
        [InQuery("currentShipmentStatus")]
        public string CurrentShipmentStatus { get; set; }

        /// <summary>
        /// Get Shipment Details by passing Vendor Shipment ID
        /// </summary>
        [InQuery("vendorShipmentIdentifier")]
        public string VendorShipmentIdentifier { get; set; }

        /// <summary>
        /// Get Shipment Details by passing buyer Reference ID
        /// </summary>
        [InQuery("buyerReferenceNumber")]
        public string BuyerReferenceNumber { get; set; }

        /// <summary>
        /// Get Shipping Details based on buyer warehouse code. This value should be same as 'shipToParty.partyId'
        /// in the Shipment.
        /// </summary>
        [InQuery("buyerWarehouseCode")]
        public string BuyerWarehouseCode { get; set; }

        /// <summary>
        /// Get Shipping Details based on vendor warehouse code. This value should be same as 'sellingParty.partyId'
        /// in the Shipment.
        /// </summary>
        [InQuery("sellerWarehouseCode")]
        public string SellerWarehouseCode { get; set; }
    }
}
