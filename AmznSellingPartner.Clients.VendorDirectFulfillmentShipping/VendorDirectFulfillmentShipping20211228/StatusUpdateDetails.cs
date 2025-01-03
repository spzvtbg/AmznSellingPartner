namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Details for the shipment status update given by the vendor for the specific package
	/// </summary>
	public class StatusUpdateDetails : BaseClass
	{
		/// <summary>
		/// The shipment tracking number is required for every package and should match the `trackingNumber` sent for the
		/// hipment confirmation
		/// </summary>
		[IsRequired]
		[JsonProperty("trackingNumber")]
		public string TrackingNumber { get; set; }

		/// <summary>
		/// Indicates the shipment status code of the package that provides transportation information for Amazon tracking
		/// systems and ultimately for the final customer
		/// For more information, refer to the [Additional Fields Explanation](https://developer-docs
		/// amazon
		/// com/sp-api/docs/vendor-direct-fulfillment-shipping-api-use-case-guide#additional-fields-explanation)
		/// </summary>
		[IsRequired]
		[JsonProperty("statusCode")]
		public string StatusCode { get; set; }

		/// <summary>
		/// Provides a reason code for the status of the package that will provide additional information about the transp
		/// rtation status
		/// For more information, refer to the [Additional Fields Explanation](https://developer-docs
		/// amazon
		/// com/sp-api/docs/vendor-direct-fulfillment-shipping-api-use-case-guide#additional-fields-explanation)
		/// </summary>
		[IsRequired]
		[JsonProperty("reasonCode")]
		public string ReasonCode { get; set; }

		/// <summary>
		/// The date and time when the shipment status was updated
		/// Values are in [ISO 8601](https://developer-docs
		/// amazon
		/// com/sp-api/docs/iso-8601) date-time format, with UTC time zone or UTC offset
		/// For example, 2020-07-16T23:00:00Z or 2020-07-16T23:00:00+01:00
		/// </summary>
		[IsRequired]
		[JsonProperty("statusDateTime")]
		public DateTime StatusDateTime { get; set; }

		[IsRequired]
		[JsonProperty("statusLocationAddress")]
		public Address StatusLocationAddress { get; set; }

		[JsonProperty("shipmentSchedule")]
		public ShipmentSchedule ShipmentSchedule { get; set; }
	}
}
