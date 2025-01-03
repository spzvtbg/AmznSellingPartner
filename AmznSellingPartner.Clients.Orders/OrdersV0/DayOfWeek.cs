namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum DayOfWeek
	{
		/// <summary>
		/// Sunday - Day of the week.
		/// </summary>
		[EnumMember(Value = "SUN")]
		SUN,

		/// <summary>
		/// Monday - Day of the week.
		/// </summary>
		[EnumMember(Value = "MON")]
		MON,

		/// <summary>
		/// Tuesday - Day of the week.
		/// </summary>
		[EnumMember(Value = "TUE")]
		TUE,

		/// <summary>
		/// Wednesday - Day of the week.
		/// </summary>
		[EnumMember(Value = "WED")]
		WED,

		/// <summary>
		/// Thursday - Day of the week.
		/// </summary>
		[EnumMember(Value = "THU")]
		THU,

		/// <summary>
		/// Friday - Day of the week.
		/// </summary>
		[EnumMember(Value = "FRI")]
		FRI,

		/// <summary>
		/// Saturday - Day of the week.
		/// </summary>
		[EnumMember(Value = "SAT")]
		SAT,
	}
}
