namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The day of the week.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DayOfWeek
	{
		/// <summary>
		/// Monday.
		/// </summary>
		[EnumMember(Value = "MONDAY")]
		MONDAY,

		/// <summary>
		/// Tuesday.
		/// </summary>
		[EnumMember(Value = "TUESDAY")]
		TUESDAY,

		/// <summary>
		/// Wednesday.
		/// </summary>
		[EnumMember(Value = "WEDNESDAY")]
		WEDNESDAY,

		/// <summary>
		/// Thursday.
		/// </summary>
		[EnumMember(Value = "THURSDAY")]
		THURSDAY,

		/// <summary>
		/// Friday.
		/// </summary>
		[EnumMember(Value = "FRIDAY")]
		FRIDAY,

		/// <summary>
		/// Saturday.
		/// </summary>
		[EnumMember(Value = "SATURDAY")]
		SATURDAY,

		/// <summary>
		/// Sunday.
		/// </summary>
		[EnumMember(Value = "SUNDAY")]
		SUNDAY,
	}
}
