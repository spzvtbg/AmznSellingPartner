namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// General information about a fulfillment order, including its status.
	/// </summary>
	public class FulfillmentOrder : BaseClass
	{
		/// <summary>
		/// The fulfillment order identifier submitted with the `createFulfillmentOrder` operation.
		/// </summary>
		[JsonProperty("sellerFulfillmentOrderId")]
		[IsRequired]
		public string SellerFulfillmentOrderId { get; set; } 

		/// <summary>
		/// The identifier for the marketplace the fulfillment order is placed against.
		/// </summary>
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; } 

		/// <summary>
		/// A fulfillment order identifier submitted with the `createFulfillmentOrder` operation. Displays as the
		/// order identifier in recipient-facing materials such as the packing slip.
		/// </summary>
		[JsonProperty("displayableOrderId")]
		[IsRequired]
		public string DisplayableOrderId { get; set; } 

		/// <summary>
		/// A date and time submitted with the `createFulfillmentOrder` operation. Displays as the order date in
		/// recipient-facing materials such as the packing slip.
		/// </summary>
		[JsonProperty("displayableOrderDate")]
		[IsRequired]
		public Timestamp DisplayableOrderDate { get; set; } 

		/// <summary>
		/// A text block submitted with the `createFulfillmentOrder` operation. Displays in recipient-facing materials
		/// such as the packing slip.
		/// </summary>
		[JsonProperty("displayableOrderComment")]
		[IsRequired]
		public string DisplayableOrderComment { get; set; } 

		[JsonProperty("shippingSpeedCategory")]
		[IsRequired]
		public ShippingSpeedCategory ShippingSpeedCategory { get; set; } 

		[JsonProperty("deliveryWindow")]
		public DeliveryWindow DeliveryWindow { get; set; } 

		/// <summary>
		/// The destination address submitted with the `createFulfillmentOrder` operation.
		/// </summary>
		[JsonProperty("destinationAddress")]
		[IsRequired]
		public Address DestinationAddress { get; set; } 

		[JsonProperty("fulfillmentAction")]
		public FulfillmentAction FulfillmentAction { get; set; } 

		[JsonProperty("fulfillmentPolicy")]
		public FulfillmentPolicy FulfillmentPolicy { get; set; } 

		[JsonProperty("codSettings")]
		public CODSettings CodSettings { get; set; } 

		/// <summary>
		/// The date and time that the fulfillment order was received by an Amazon fulfillment center.
		/// </summary>
		[JsonProperty("receivedDate")]
		[IsRequired]
		public Timestamp ReceivedDate { get; set; } 

		[JsonProperty("fulfillmentOrderStatus")]
		[IsRequired]
		public FulfillmentOrderStatus FulfillmentOrderStatus { get; set; } 

		/// <summary>
		/// The date and time that the status of the fulfillment order last changed. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[JsonProperty("statusUpdatedDate")]
		[IsRequired]
		public Timestamp StatusUpdatedDate { get; set; } 

		[JsonProperty("notificationEmails")]
		public NotificationEmailList NotificationEmails { get; set; } 

		/// <summary>
		/// A list of features and their fulfillment policies to apply to the order.
		/// </summary>
		[JsonProperty("featureConstraints")]
		public List<FeatureSettings> FeatureConstraints { get; set; } 
	}
}
