namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request body schema for the `updateFulfillmentOrder` operation.
	/// </summary>
	public class UpdateFulfillmentOrderRequest : BaseClass
	{
		/// <summary>
		/// The marketplace the fulfillment order is placed against.
		/// </summary>
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; } 

		/// <summary>
		/// A fulfillment order identifier that the seller creates. This value displays as the order identifier
		/// in recipient-facing materials such as the outbound shipment packing slip. The value of `DisplayableOrderId`
		/// should match the order identifier that the seller provides to the recipient. The seller can
		/// use the `SellerFulfillmentOrderId` for this value or they can specify an alternate value if
		/// they want the recipient to reference an alternate order identifier.
		/// </summary>
		[JsonProperty("displayableOrderId")]
		[MaxLength(40)]
		public string DisplayableOrderId { get; set; } 

		/// <summary>
		/// The date and time of the fulfillment order. Displays as the order date in recipient-facing
		/// materials such as the outbound shipment packing slip.
		/// </summary>
		[JsonProperty("displayableOrderDate")]
		public Timestamp DisplayableOrderDate { get; set; } 

		/// <summary>
		/// Order-specific text that appears in recipient-facing materials such as the outbound shipment
		/// packing slip.
		/// </summary>
		[JsonProperty("displayableOrderComment")]
		[MaxLength(750)]
		public string DisplayableOrderComment { get; set; } 

		[JsonProperty("shippingSpeedCategory")]
		public ShippingSpeedCategory ShippingSpeedCategory { get; set; } 

		/// <summary>
		/// The destination address for the fulfillment order.
		/// </summary>
		[JsonProperty("destinationAddress")]
		public Address DestinationAddress { get; set; } 

		[JsonProperty("fulfillmentAction")]
		public FulfillmentAction FulfillmentAction { get; set; } 

		[JsonProperty("fulfillmentPolicy")]
		public FulfillmentPolicy FulfillmentPolicy { get; set; } 

		/// <summary>
		/// The two-character country code for the country from which the fulfillment order ships. Must
		/// be in ISO 3166-1 alpha-2 format.
		/// </summary>
		[JsonProperty("shipFromCountryCode")]
		public string ShipFromCountryCode { get; set; } 

		[JsonProperty("notificationEmails")]
		public NotificationEmailList NotificationEmails { get; set; } 

		/// <summary>
		/// A list of features and their fulfillment policies to apply to the order.
		/// </summary>
		[JsonProperty("featureConstraints")]
		public List<FeatureSettings> FeatureConstraints { get; set; } 

		/// <summary>
		/// A list of items to include in the fulfillment order preview, including quantity.
		/// </summary>
		[JsonProperty("items")]
		public UpdateFulfillmentOrderItemList Items { get; set; } 
	}
}
