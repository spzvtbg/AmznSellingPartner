namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	/// <summary>
	/// Contains information pertaining to a delivery window option.
	/// </summary>
	public class DeliveryWindowOption : BaseClass
	{
		/// <summary>
		/// Identifies type of Delivery Window Availability. Values: `AVAILABLE`, `CONGESTED`
		/// </summary>
		[JsonProperty("availabilityType")]
		[IsRequired]
		public string AvailabilityType { get; set; } 

		/// <summary>
		/// Identifier of a delivery window option. A delivery window option represent one option for when
		/// a shipment is expected to be delivered.
		/// </summary>
		[JsonProperty("deliveryWindowOptionId")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(36)]
		[MaxLength(38)]
		public string DeliveryWindowOptionId { get; set; } 

		/// <summary>
		/// The time at which this delivery window option ends. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// datetime format with pattern `yyyy-MM-ddTHH:mmZ`.
		/// </summary>
		[JsonProperty("endDate")]
		[IsRequired]
		public DateTimeValue EndDate { get; set; } 

		/// <summary>
		/// The time at which this delivery window option starts. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// datetime format with pattern `yyyy-MM-ddTHH:mmZ`.
		/// </summary>
		[JsonProperty("startDate")]
		[IsRequired]
		public DateTimeValue StartDate { get; set; } 

		/// <summary>
		/// The time at which this window delivery option is no longer valid. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// datetime format with pattern `yyyy-MM-ddTHH:mmZ`.
		/// </summary>
		[JsonProperty("validUntil")]
		[IsRequired]
		public DateTimeValue ValidUntil { get; set; } 
	}
}
