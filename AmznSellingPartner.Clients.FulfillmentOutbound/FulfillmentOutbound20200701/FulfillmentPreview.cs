namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Information about a fulfillment order preview, including delivery and fee information based on shipping
	/// method.
	/// </summary>
	public class FulfillmentPreview : BaseClass
	{
		[JsonProperty("shippingSpeedCategory")]
		[IsRequired]
		public ShippingSpeedCategory ShippingSpeedCategory { get; set; }

		[JsonProperty("scheduledDeliveryInfo")]
		public ScheduledDeliveryInfo ScheduledDeliveryInfo { get; set; }

		/// <summary>
		/// When true, this fulfillment order preview is fulfillable.
		/// </summary>
		[JsonProperty("isFulfillable")]
		[IsRequired]
		public bool IsFulfillable { get; set; }

		/// <summary>
		/// When true, this fulfillment order preview is for COD (Cash On Delivery).
		/// </summary>
		[JsonProperty("isCODCapable")]
		[IsRequired]
		public bool IsCODCapable { get; set; }

		/// <summary>
		/// Estimated shipping weight for this fulfillment order preview.
		/// </summary>
		[JsonProperty("estimatedShippingWeight")]
		public Weight EstimatedShippingWeight { get; set; }

		/// <summary>
		/// The estimated fulfillment fees for this fulfillment order preview, if applicable. The fees data will
		/// not be available for IN marketplace orders.
		/// </summary>
		[JsonProperty("estimatedFees")]
		public FeeList EstimatedFees { get; set; }

		[JsonProperty("fulfillmentPreviewShipments")]
		public FulfillmentPreviewShipmentList FulfillmentPreviewShipments { get; set; }

		[JsonProperty("unfulfillablePreviewItems")]
		public UnfulfillablePreviewItemList UnfulfillablePreviewItems { get; set; }

		/// <summary>
		/// Error codes associated with the fulfillment order preview that indicate why the order is not fulfillable.
		/// Error code examples:  `DeliverySLAUnavailable` `InvalidDestinationAddress`
		/// </summary>
		[JsonProperty("orderUnfulfillableReasons")]
		public StringList OrderUnfulfillableReasons { get; set; }

		/// <summary>
		/// The marketplace the fulfillment order is placed against.
		/// </summary>
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// A list of features and their fulfillment policies to apply to the order.
		/// </summary>
		[JsonProperty("featureConstraints")]
		public List<FeatureSettings> FeatureConstraints { get; set; }
	}
}
