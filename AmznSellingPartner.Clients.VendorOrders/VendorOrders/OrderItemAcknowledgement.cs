namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Represents the acknowledgement details for an individual order item, including the acknowledgement code, ackno
	/// ledged quantity, scheduled ship and delivery dates, and rejection reason (if applicable)
	/// </summary>
	public class OrderItemAcknowledgement : BaseClass
	{
		/// <summary>
		/// This indicates the acknowledgement code
		/// </summary>
		[IsRequired]
		[JsonProperty("acknowledgementCode")]
		public AcknowledgementCode AcknowledgementCode { get; set; }

		/// <summary>
		/// Details of quantity acknowledged with the above acknowledgement code
		/// </summary>
		[IsRequired]
		[JsonProperty("acknowledgedQuantity")]
		public ItemQuantity AcknowledgedQuantity { get; set; }

		/// <summary>
		/// Estimated ship date per line item
		/// Must be in ISO-8601 date/time format
		/// </summary>
		[JsonProperty("scheduledShipDate")]
		public DateTime ScheduledShipDate { get; set; }

		/// <summary>
		/// Estimated delivery date per line item
		/// Must be in ISO-8601 date/time format
		/// </summary>
		[JsonProperty("scheduledDeliveryDate")]
		public DateTime ScheduledDeliveryDate { get; set; }

		/// <summary>
		/// Indicates the reason for rejection
		/// </summary>
		[JsonProperty("rejectionReason")]
		public RejectionReason RejectionReason { get; set; }
	}
}
