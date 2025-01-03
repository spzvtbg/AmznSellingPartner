namespace AmznSellingPartner.Clients.Sales.Sales
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum FirstDayOfWeek
	{
		/// <summary>
		/// Monday
		/// </summary>
		[EnumMember(Value = "Monday")]
		Monday,

		/// <summary>
		/// Sunday
		/// </summary>
		[EnumMember(Value = "Sunday")]
		Sunday,
	}
}
