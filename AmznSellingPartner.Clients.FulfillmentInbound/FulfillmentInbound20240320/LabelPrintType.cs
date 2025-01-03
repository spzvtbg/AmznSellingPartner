namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Indicates the type of print type for a given label.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LabelPrintType
	{
		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "STANDARD_FORMAT")]
		STANDARD_FORMAT,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "THERMAL_PRINTING")]
		THERMAL_PRINTING,
	}
}
