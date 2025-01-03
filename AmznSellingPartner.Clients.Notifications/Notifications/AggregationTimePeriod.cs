namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The supported aggregation time periods. For example, if FiveMinutes is the value chosen, and 50 price updates
	/// ccur for an ASIN within 5 minutes, Amazon will send only two notifications; one for the first event, and then
	/// subsequent notification 5 minutes later with the final end state of the data. The 48 interim events will be d
	/// opped.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AggregationTimePeriod
	{
		/// <summary>
		/// An aggregated notification will be sent every five minutes.
		/// </summary>
		[EnumMember(Value = "FiveMinutes")]
		FiveMinutes,

		/// <summary>
		/// An aggregated notification will be sent every ten minutes.
		/// </summary>
		[EnumMember(Value = "TenMinutes")]
		TenMinutes,
	}
}
