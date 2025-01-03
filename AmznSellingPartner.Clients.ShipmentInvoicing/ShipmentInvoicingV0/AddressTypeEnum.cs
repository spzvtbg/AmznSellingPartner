namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The shipping address type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AddressTypeEnum
	{
		/// <summary>
		/// The address type is residential.
		/// </summary>
		[EnumMember(Value = "Residential")]
		Residential,

		/// <summary>
		/// The address type is commercial.
		/// </summary>
		[EnumMember(Value = "Commercial")]
		Commercial,
	}
}
