namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Reason for cancelling or rescheduling a self-ship appointment
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ReasonComment
	{
		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "APPOINTMENT_REQUESTED_BY_MISTAKE")]
		APPOINTMENT_REQUESTED_BY_MISTAKE,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "VEHICLE_DELAY")]
		VEHICLE_DELAY,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "SLOT_NOT_SUITABLE")]
		SLOT_NOT_SUITABLE,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "OUTSIDE_CARRIER_BUSINESS_HOURS")]
		OUTSIDE_CARRIER_BUSINESS_HOURS,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "UNFAVOURABLE_EXTERNAL_CONDITIONS")]
		UNFAVOURABLE_EXTERNAL_CONDITIONS,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "PROCUREMENT_DELAY")]
		PROCUREMENT_DELAY,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "SHIPPING_PLAN_CHANGED")]
		SHIPPING_PLAN_CHANGED,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "INCREASED_QUANTITY")]
		INCREASED_QUANTITY,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "OTHER")]
		OTHER,
	}
}
