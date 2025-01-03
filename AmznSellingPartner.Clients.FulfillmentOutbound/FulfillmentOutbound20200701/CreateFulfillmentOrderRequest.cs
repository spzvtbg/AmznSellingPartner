namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request body schema for the `createFulfillmentOrder` operation.
	/// </summary>
	public class CreateFulfillmentOrderRequest : BaseClass
	{
		/// <summary>
		/// The marketplace the fulfillment order is placed against.
		/// </summary>
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// A fulfillment order identifier that the seller creates to track their fulfillment order. The `SellerFulfillmen
		/// OrderId` must be unique for each fulfillment order that a seller creates. If the seller's system already creat
		/// s unique order identifiers, then these might be good values for them to use.
		/// </summary>
		[IsRequired]
		[MaxLength(40)]
		[JsonProperty("sellerFulfillmentOrderId")]
		public string SellerFulfillmentOrderId { get; set; }

		/// <summary>
		/// A fulfillment order identifier that the seller creates. This value displays as the order identifier in recipie
		/// t-facing materials such as the outbound shipment packing slip. The value of `DisplayableOrderId` should match
		/// he order identifier that the seller provides to the recipient. The seller can use the `SellerFulfillmentOrderI
		/// ` for this value or they can specify an alternate value if they want the recipient to reference an alternate o
		/// der identifier.  The value must be an alpha-numeric or ISO 8859-1 compliant string from one to 40 characters i
		/// length. Cannot contain two spaces in a row. Leading and trailing white space is removed.
		/// </summary>
		[IsRequired]
		[MaxLength(40)]
		[JsonProperty("displayableOrderId")]
		public string DisplayableOrderId { get; set; }

		/// <summary>
		/// The date and time of the fulfillment order. Displays as the order date in recipient-facing materials such as t
		/// e outbound shipment packing slip.
		/// </summary>
		[IsRequired]
		[JsonProperty("displayableOrderDate")]
		public Timestamp DisplayableOrderDate { get; set; }

		/// <summary>
		/// Order-specific text that appears in recipient-facing materials such as the outbound shipment packing slip.
		/// </summary>
		[IsRequired]
		[MaxLength(750)]
		[JsonProperty("displayableOrderComment")]
		public string DisplayableOrderComment { get; set; }

		/// <summary>
		/// The shipping method for the fulfillment order. When this value is `ScheduledDelivery`, choose Ship for the `fu
		/// fillmentAction`. Hold is not a valid `fulfillmentAction` value when the `shippingSpeedCategory` value is `Sche
		/// uledDelivery`. Note: Shipping method service level agreements vary by marketplace. Sellers can refer to [Selle
		/// Central]( https://developer-docs.amazon.com/sp-api/docs/seller-central-urls) for shipping method service-leve
		/// agreements and multi-channel fulfillment fees.
		/// </summary>
		[IsRequired]
		[JsonProperty("shippingSpeedCategory")]
		public ShippingSpeedCategory ShippingSpeedCategory { get; set; }

		[JsonProperty("deliveryWindow")]
		public DeliveryWindow DeliveryWindow { get; set; }

		/// <summary>
		/// The destination address for the fulfillment order.
		/// </summary>
		[IsRequired]
		[JsonProperty("destinationAddress")]
		public Address DestinationAddress { get; set; }

		/// <summary>
		/// The delivery preferences applied to the destination address. These preferences are applied when possible and a
		/// e best effort. For eligible orders, the default delivery preference is to leave the package unattended at the
		/// ront door. This feature is currently supported only in the JP marketplace and not applicable for other marketp
		/// aces. For eligible orders, the default delivery preference will be to deliver the package unattended at the fr
		/// nt door, unless you specify otherwise.
		/// </summary>
		[JsonProperty("deliveryPreferences")]
		public DeliveryPreferences DeliveryPreferences { get; set; }

		[JsonProperty("fulfillmentAction")]
		public FulfillmentAction FulfillmentAction { get; set; }

		[JsonProperty("fulfillmentPolicy")]
		public FulfillmentPolicy FulfillmentPolicy { get; set; }

		[JsonProperty("codSettings")]
		public CODSettings CodSettings { get; set; }

		/// <summary>
		/// The two-character country code for the country from which the fulfillment order ships. Must be in ISO 3166-1 a
		/// pha-2 format.
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
		/// A list of items to include in the fulfillment order preview, including quantity. Maximum of 100 line items wit
		/// a maximum of 250 units per order.
		/// </summary>
		[IsRequired]
		[JsonProperty("items")]
		public CreateFulfillmentOrderItemList Items { get; set; }

		/// <summary>
		/// An array of various payment attributes related to this fulfillment order. This property is required if the ord
		/// r is placed against the India marketplace.
		/// </summary>
		[JsonProperty("paymentInformation")]
		public PaymentInformationList PaymentInformation { get; set; }
	}
}
