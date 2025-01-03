namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The supported statuses for an inbound order.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum InboundStatus
	{
		/// <summary>
		/// A newly created inbound order will start in this state.
		/// </summary>
		[EnumMember(Value = "DRAFT")]
		DRAFT,

		/// <summary>
		/// The order is in this state while being updated. Once updated, the order will enter the updated state
		/// .
		/// </summary>
		[EnumMember(Value = "VALIDATING")]
		VALIDATING,

		/// <summary>
		/// The order enters this state as soon as the order is confirmed.
		/// </summary>
		[EnumMember(Value = "CONFIRMED")]
		CONFIRMED,

		/// <summary>
		/// The order enters this state when all associated shipments are closed.
		/// </summary>
		[EnumMember(Value = "CLOSED")]
		CLOSED,

		/// <summary>
		/// The order enters this state if it is not confirmed within a time limit.
		/// </summary>
		[EnumMember(Value = "EXPIRED")]
		EXPIRED,

		[EnumMember(Value = "CANCELLED")]
		CANCELLED,
	}
}
