namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Contains information pertaining to a delivery window option.
	/// </summary>
	public class DeliveryWindowOption : BaseClass
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
		/// The time at which this delivery window option ends. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// datetime format with pattern `yyyy-MM-ddTHH:mmZ`.
		/// </summary>
		[IsRequired]
		[JsonProperty("endDate")]
		public DateTime EndDate { get; set; }

		/// <summary>
		/// The time at which this delivery window option starts. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// datetime format with pattern `yyyy-MM-ddTHH:mmZ`.
		/// </summary>
		[IsRequired]
		[JsonProperty("startDate")]
		public DateTime StartDate { get; set; }

		/// <summary>
		/// The time at which this window delivery option is no longer valid. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// datetime format with pattern `yyyy-MM-ddTHH:mmZ`.
		/// </summary>
		[IsRequired]
		[JsonProperty("validUntil")]
		public DateTime ValidUntil { get; set; }
	}
}
