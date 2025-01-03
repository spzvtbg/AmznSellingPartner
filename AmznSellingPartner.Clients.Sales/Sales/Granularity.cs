namespace AmznSellingPartner.Clients.Sales.Sales
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Granularity
	{
		/// <summary>
		/// Hour
		/// </summary>
		[EnumMember(Value = "Hour")]
		Hour,

		/// <summary>
		/// Day
		/// </summary>
		[EnumMember(Value = "Day")]
		Day,

		/// <summary>
		/// Week
		/// </summary>
		[EnumMember(Value = "Week")]
		Week,

		/// <summary>
		/// Month
		/// </summary>
		[EnumMember(Value = "Month")]
		Month,

		/// <summary>
		/// Year
		/// </summary>
		[EnumMember(Value = "Year")]
		Year,

		/// <summary>
		/// Total
		/// </summary>
		[EnumMember(Value = "Total")]
		Total,
	}
}
