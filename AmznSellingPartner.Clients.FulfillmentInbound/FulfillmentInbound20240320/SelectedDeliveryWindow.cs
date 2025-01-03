namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Selected delivery window attributes.
	/// </summary>
	public class SelectedDeliveryWindow : BaseClass
	{
		/// <summary>
		/// Identifies type of Delivery Window Availability. Values: `AVAILABLE`, `CONGESTED`
		/// </summary>
		[IsRequired]
		[JsonProperty("availabilityType")]
		public string AvailabilityType { get; set; }

		/// <summary>
		/// Identifier of a delivery window option. A delivery window option represent one option for when a shipment
		/// is expected to be delivered.
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(36)]
		[MaxLength(38)]
		[JsonProperty("deliveryWindowOptionId")]
		public string DeliveryWindowOptionId { get; set; }

		/// <summary>
		/// The timestamp at which this Window can no longer be edited.
		/// </summary>
		[JsonProperty("editableUntil")]
		public DateTime EditableUntil { get; set; }

		/// <summary>
		/// The end timestamp of the window.
		/// </summary>
		[IsRequired]
		[JsonProperty("endDate")]
		public DateTime EndDate { get; set; }

		/// <summary>
		/// The start timestamp of the window.
		/// </summary>
		[IsRequired]
		[JsonProperty("startDate")]
		public DateTime StartDate { get; set; }
	}
}
