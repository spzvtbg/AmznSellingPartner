namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The type of parking spot identification.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ParkingSpotIdentificationType
	{
		[EnumMember(Value = "Numbered")]
		Numbered,

		[EnumMember(Value = "Other")]
		Other,
	}
}
