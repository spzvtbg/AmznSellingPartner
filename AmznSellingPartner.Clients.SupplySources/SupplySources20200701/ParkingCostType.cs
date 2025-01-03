namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The parking cost type
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ParkingCostType
	{
		[EnumMember(Value = "Free")]
		Free,

		[EnumMember(Value = "Other")]
		Other,
	}
}
