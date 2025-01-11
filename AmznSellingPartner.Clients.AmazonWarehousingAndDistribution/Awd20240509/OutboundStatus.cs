namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Statuses supported for an outbound order.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OutboundStatus
	{
		/// <summary>
		/// The order enters this state as soon as the order is confirmed.
		/// </summary>
		[EnumMember(Value = "CONFIRMED")]
		CONFIRMED,

		/// <summary>
		/// A newly created outbound order will always start in this state.
		/// </summary>
		[EnumMember(Value = "DRAFT")]
		DRAFT,

		/// <summary>
		/// This is the only state when an order can be confirmed.
		/// </summary>
		[EnumMember(Value = "ELIGIBLE")]
		ELIGIBLE,

		/// <summary>
		/// The order is being processed in the system.
		/// </summary>
		[EnumMember(Value = "EXECUTING")]
		EXECUTING,

		/// <summary>
		/// If any of the shipment reports fail, or if a shipment doesn't reach its destination, the order
		/// status is marked as failed.
		/// </summary>
		[EnumMember(Value = "FAILURE")]
		FAILURE,

		/// <summary>
		/// In this state, a validation errors field is provided. This field shows the order errors and
		/// provides guidance on fixing them.
		/// </summary>
		[EnumMember(Value = "INELIGIBLE")]
		INELIGIBLE,

		/// <summary>
		/// The order is complete and awaits inventory movement. In this status, the shipments for an order
		/// will be visible.
		/// </summary>
		[EnumMember(Value = "INVENTORY_OUTBOUND")]
		INVENTORY_OUTBOUND,

		/// <summary>
		/// If all the shipments are successfully received at the destination channel, the order is marked
		/// successful.
		/// </summary>
		[EnumMember(Value = "SUCCESS")]
		SUCCESS,

		/// <summary>
		/// The order is being validated asynchronously. The order will be in this state after every item
		/// update.
		/// </summary>
		[EnumMember(Value = "VALIDATING")]
		VALIDATING,
	}
}
