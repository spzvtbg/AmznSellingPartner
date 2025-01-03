namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum FunctionCode
	{
		/// <summary>
		/// Port of Discharge is a place where a vessel discharges or unloads some or all of its shipments
		/// </summary>
		[EnumMember(Value = "PortOfDischarge")]
		PortOfDischarge,

		/// <summary>
		/// Place where the payment for the freight is made
		/// </summary>
		[EnumMember(Value = "FreightPayableAt")]
		FreightPayableAt,

		/// <summary>
		/// The port where goods are put on a ship
		/// </summary>
		[EnumMember(Value = "PortOfLoading")]
		PortOfLoading,
	}
}
