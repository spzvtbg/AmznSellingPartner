namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ContainerType
	{
		/// <summary>
		/// A carton is a box or container usually made of liquid packaging board, paperboard and sometimes of corrugated
		/// fiberboard
		/// </summary>
		[EnumMember(Value = "carton")]
		carton,

		/// <summary>
		/// A flat transport structure which supports goods in a stable fashion while being lifted by a forklift
		/// .
		/// </summary>
		[EnumMember(Value = "pallet")]
		pallet,
	}
}
