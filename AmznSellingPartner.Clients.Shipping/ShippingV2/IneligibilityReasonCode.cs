namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Reasons that make a shipment service offering ineligible.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum IneligibilityReasonCode
	{
		/// <summary>
		/// The shipment is ineligible because there is no coverage to that address.
		/// </summary>
		[EnumMember(Value = "NO_COVERAGE")]
		NO_COVERAGE,

		/// <summary>
		/// The shipment is ineligible because there is an issue with the pickup slot.
		/// </summary>
		[EnumMember(Value = "PICKUP_SLOT_RESTRICTION")]
		PICKUP_SLOT_RESTRICTION,

		/// <summary>
		/// The shipment is ineligible because the value-added service is invalid for this shipment.
		/// </summary>
		[EnumMember(Value = "UNSUPPORTED_VAS")]
		UNSUPPORTED_VAS,

		/// <summary>
		/// The shipment is ineligible because an invalid combination of value-added services were cho
		/// sen.
		/// </summary>
		[EnumMember(Value = "VAS_COMBINATION_RESTRICTION")]
		VAS_COMBINATION_RESTRICTION,

		/// <summary>
		/// The shipment is ineligible because the package dimensions are unsupported.
		/// </summary>
		[EnumMember(Value = "SIZE_RESTRICTIONS")]
		SIZE_RESTRICTIONS,

		/// <summary>
		/// The shipment is ineligible because the weight is unsupported.
		/// </summary>
		[EnumMember(Value = "WEIGHT_RESTRICTIONS")]
		WEIGHT_RESTRICTIONS,

		/// <summary>
		/// The shipment is ineligible because delivery is too late.
		/// </summary>
		[EnumMember(Value = "LATE_DELIVERY")]
		LATE_DELIVERY,

		/// <summary>
		/// The shipment is ineligible because of program constraints.
		/// </summary>
		[EnumMember(Value = "PROGRAM_CONSTRAINTS")]
		PROGRAM_CONSTRAINTS,

		/// <summary>
		/// The shipment is ineligible because terms and conditions have not been accepted by the carr
		/// ier.
		/// </summary>
		[EnumMember(Value = "TERMS_AND_CONDITIONS_NOT_ACCEPTED")]
		TERMS_AND_CONDITIONS_NOT_ACCEPTED,

		/// <summary>
		/// The ineligibility reason is unknown.
		/// </summary>
		[EnumMember(Value = "UNKNOWN")]
		UNKNOWN,
	}
}
