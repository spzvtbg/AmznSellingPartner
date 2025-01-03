namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	[HttpGet("/vendor/shipping/v1/shipments")]
	public class GetShipmentDetailsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The limit to the number of records returned. Default value is 50 records.
		/// </summary>
		[InQuery("limit")]
		[Minimum(1)]
		[Maximum(50)]
		[JsonProperty("limit")]
		public long Limit { get; set; }

		/// <summary>
		/// Sort in ascending or descending order by purchase order creation date.
		/// </summary>
		[InQuery("sortOrder")]
		[JsonProperty("sortOrder")]
		public SortOrder SortOrder { get; set; }

		/// <summary>
		/// Used for pagination when there are more shipments than the specified result size limit.
		/// </summary>
		[InQuery("nextToken")]
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }

		/// <summary>
		/// Get Shipment Details that became available after this timestamp will be included in the result. Must
		/// be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO 8601</a> format.
		/// </summary>
		[InQuery("createdAfter")]
		[JsonProperty("createdAfter")]
		public DateTime CreatedAfter { get; set; }

		/// <summary>
		/// Get Shipment Details that became available before this timestamp will be included in the result. Must
		/// be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO 8601</a> format.
		/// </summary>
		[InQuery("createdBefore")]
		[JsonProperty("createdBefore")]
		public DateTime CreatedBefore { get; set; }

		/// <summary>
		/// Get Shipment Details by passing Shipment confirmed create Date Before. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[InQuery("shipmentConfirmedBefore")]
		[JsonProperty("shipmentConfirmedBefore")]
		public DateTime ShipmentConfirmedBefore { get; set; }

		/// <summary>
		/// Get Shipment Details by passing Shipment confirmed create Date After. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[InQuery("shipmentConfirmedAfter")]
		[JsonProperty("shipmentConfirmedAfter")]
		public DateTime ShipmentConfirmedAfter { get; set; }

		/// <summary>
		/// Get Shipment Details by passing Package label create Date by buyer. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[InQuery("packageLabelCreatedBefore")]
		[JsonProperty("packageLabelCreatedBefore")]
		public DateTime PackageLabelCreatedBefore { get; set; }

		/// <summary>
		/// Get Shipment Details by passing Package label create Date After by buyer. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[InQuery("packageLabelCreatedAfter")]
		[JsonProperty("packageLabelCreatedAfter")]
		public DateTime PackageLabelCreatedAfter { get; set; }

		/// <summary>
		/// Get Shipment Details by passing Shipped Date Before. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[InQuery("shippedBefore")]
		[JsonProperty("shippedBefore")]
		public DateTime ShippedBefore { get; set; }

		/// <summary>
		/// Get Shipment Details by passing Shipped Date After. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[InQuery("shippedAfter")]
		[JsonProperty("shippedAfter")]
		public DateTime ShippedAfter { get; set; }

		/// <summary>
		/// Get Shipment Details by passing Estimated Delivery Date Before. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[InQuery("estimatedDeliveryBefore")]
		[JsonProperty("estimatedDeliveryBefore")]
		public DateTime EstimatedDeliveryBefore { get; set; }

		/// <summary>
		/// Get Shipment Details by passing Estimated Delivery Date Before. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[InQuery("estimatedDeliveryAfter")]
		[JsonProperty("estimatedDeliveryAfter")]
		public DateTime EstimatedDeliveryAfter { get; set; }

		/// <summary>
		/// Get Shipment Details by passing Shipment Delivery Date Before. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[InQuery("shipmentDeliveryBefore")]
		[JsonProperty("shipmentDeliveryBefore")]
		public DateTime ShipmentDeliveryBefore { get; set; }

		/// <summary>
		/// Get Shipment Details by passing Shipment Delivery Date After. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[InQuery("shipmentDeliveryAfter")]
		[JsonProperty("shipmentDeliveryAfter")]
		public DateTime ShipmentDeliveryAfter { get; set; }

		/// <summary>
		/// Get Shipment Details by passing Before Requested pickup date. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[InQuery("requestedPickUpBefore")]
		[JsonProperty("requestedPickUpBefore")]
		public DateTime RequestedPickUpBefore { get; set; }

		/// <summary>
		/// Get Shipment Details by passing After Requested pickup date. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[InQuery("requestedPickUpAfter")]
		[JsonProperty("requestedPickUpAfter")]
		public DateTime RequestedPickUpAfter { get; set; }

		/// <summary>
		/// Get Shipment Details by passing Before scheduled pickup date. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[InQuery("scheduledPickUpBefore")]
		[JsonProperty("scheduledPickUpBefore")]
		public DateTime ScheduledPickUpBefore { get; set; }

		/// <summary>
		/// Get Shipment Details by passing After Scheduled pickup date. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[InQuery("scheduledPickUpAfter")]
		[JsonProperty("scheduledPickUpAfter")]
		public DateTime ScheduledPickUpAfter { get; set; }

		/// <summary>
		/// Get Shipment Details by passing Current shipment status.
		/// </summary>
		[InQuery("currentShipmentStatus")]
		[JsonProperty("currentShipmentStatus")]
		public string CurrentShipmentStatus { get; set; }

		/// <summary>
		/// Get Shipment Details by passing Vendor Shipment ID
		/// </summary>
		[InQuery("vendorShipmentIdentifier")]
		[JsonProperty("vendorShipmentIdentifier")]
		public string VendorShipmentIdentifier { get; set; }

		/// <summary>
		/// Get Shipment Details by passing buyer Reference ID
		/// </summary>
		[InQuery("buyerReferenceNumber")]
		[JsonProperty("buyerReferenceNumber")]
		public string BuyerReferenceNumber { get; set; }

		/// <summary>
		/// Get Shipping Details based on buyer warehouse code. This value should be same as 'shipToParty.partyId'
		/// in the Shipment.
		/// </summary>
		[InQuery("buyerWarehouseCode")]
		[JsonProperty("buyerWarehouseCode")]
		public string BuyerWarehouseCode { get; set; }

		/// <summary>
		/// Get Shipping Details based on vendor warehouse code. This value should be same as 'sellingParty.partyId'
		/// in the Shipment.
		/// </summary>
		[InQuery("sellerWarehouseCode")]
		[JsonProperty("sellerWarehouseCode")]
		public string SellerWarehouseCode { get; set; }
	}
}
