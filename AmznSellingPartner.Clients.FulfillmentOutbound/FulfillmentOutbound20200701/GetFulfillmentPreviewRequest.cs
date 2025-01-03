namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request body schema for the `getFulfillmentPreview` operation.
	/// </summary>
	public class GetFulfillmentPreviewRequest : BaseClass
	{
		/// <summary>
		/// The marketplace the fulfillment order is placed against.
		/// </summary>
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// The destination address for the fulfillment order preview.
		/// </summary>
		[IsRequired]
		[JsonProperty("address")]
		public Address Address { get; set; }

		/// <summary>
		/// Identifying information and quantity information for the items in the fulfillment order preview. Maximum
		/// of 100 line items with a maximum of 250 units per order.
		/// </summary>
		[IsRequired]
		[JsonProperty("items")]
		public GetFulfillmentPreviewItemList Items { get; set; }

		/// <summary>
		/// A list of shipping methods used for creating fulfillment order previews.  Possible values:  * `Standard`
		/// - Standard shipping method. * `Expedited` - Expedited shipping method. * `Priority` - Priority shipping
		/// method. * `ScheduledDelivery` - Scheduled Delivery shipping method. Note: Shipping method service level
		/// agreements vary by marketplace. Sellers should refer to the Seller Central website in their marketplace
		/// for shipping method service level agreements and fulfillment fees.
		/// </summary>
		[JsonProperty("shippingSpeedCategories")]
		public ShippingSpeedCategoryList ShippingSpeedCategories { get; set; }

		/// <summary>
		/// When true, returns all fulfillment order previews both for COD and not for COD. Otherwise, returns only
		/// fulfillment order previews that are not for COD.
		/// </summary>
		[JsonProperty("includeCODFulfillmentPreview")]
		public bool IncludeCODFulfillmentPreview { get; set; }

		/// <summary>
		/// When true, returns the `ScheduledDeliveryInfo` response object, which contains the available delivery
		/// windows for a Scheduled Delivery. The `ScheduledDeliveryInfo` response object can only be returned for
		/// fulfillment order previews with `ShippingSpeedCategories` = `ScheduledDelivery`.
		/// </summary>
		[JsonProperty("includeDeliveryWindows")]
		public bool IncludeDeliveryWindows { get; set; }

		/// <summary>
		/// A list of features and their fulfillment policies to apply to the order.
		/// </summary>
		[JsonProperty("featureConstraints")]
		public List<FeatureSettings> FeatureConstraints { get; set; }
	}
}
