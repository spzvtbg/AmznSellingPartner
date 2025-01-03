namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The time period type that determines whether the metrics requested are backward-looking (performance) or forwa
	/// d-looking (forecast).
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TimePeriodType
	{
		/// <summary>
		/// Indicates past performance metrics.
		/// </summary>
		[EnumMember(Value = "PERFORMANCE")]
		PERFORMANCE,

		/// <summary>
		/// Indicates forecasted metrics. Only `TOTAL_SUBSCRIPTIONS_REVENUE` and `SHIPPED_SUBSCRIPTION_UNITS` are supporte
		/// . Forecast data is supported for sellers but not for vendors.
		/// </summary>
		[EnumMember(Value = "FORECAST")]
		FORECAST,
	}
}
