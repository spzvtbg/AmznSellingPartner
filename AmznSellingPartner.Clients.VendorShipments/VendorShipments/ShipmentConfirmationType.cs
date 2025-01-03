namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShipmentConfirmationType
	{
		/// <summary>
		/// Initial shipment confirmation message
		/// </summary>
		[EnumMember(Value = "Original")]
		Original,

		/// <summary>
		/// Replace the original shipment confirmation message
		/// </summary>
		[EnumMember(Value = "Replace")]
		Replace,
	}
}
