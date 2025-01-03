namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The time period used to group data in the response. Note that this is only valid for the `PERFORMANCE`
	/// time period type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AggregationFrequency
	{
		/// <summary>
		/// ISO Calendar Week.
		/// </summary>
		[EnumMember(Value = "WEEK")]
		WEEK,

		/// <summary>
		/// ISO Calendar Month.
		/// </summary>
		[EnumMember(Value = "MONTH")]
		MONTH,

		/// <summary>
		/// ISO Calendar Quarter.
		/// </summary>
		[EnumMember(Value = "QUARTER")]
		QUARTER,

		/// <summary>
		/// ISO Calendar Year.
		/// </summary>
		[EnumMember(Value = "YEAR")]
		YEAR,
	}
}
