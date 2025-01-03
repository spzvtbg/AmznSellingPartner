namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum TransportationMode
	{
		/// <summary>
		/// The mode of transportation is by Road (on a truck)
		/// </summary>
		[EnumMember(Value = "Road")]
		Road,

		/// <summary>
		/// The mode of transportation is by Air (on a plane)
		/// </summary>
		[EnumMember(Value = "Air")]
		Air,

		/// <summary>
		/// The mode of transportation is by Ocean (on a ship)
		/// </summary>
		[EnumMember(Value = "Ocean")]
		Ocean,
	}
}
