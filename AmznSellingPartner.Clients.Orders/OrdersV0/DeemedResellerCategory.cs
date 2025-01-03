namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum DeemedResellerCategory
	{
		/// <summary>
		/// Import one stop shop. The item being purchased is not held in the EU for shipment.
		/// </summary>
		[EnumMember(Value = "IOSS")]
		IOSS,

		/// <summary>
		/// Union one stop shop. The item being purchased is held in the EU for shipment.
		/// </summary>
		[EnumMember(Value = "UOSS")]
		UOSS,
	}
}
