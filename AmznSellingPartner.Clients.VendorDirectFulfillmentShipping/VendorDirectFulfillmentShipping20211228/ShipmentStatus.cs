namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShipmentStatus
	{
		/// <summary>
		/// Orders that have left the warehouse have shipped status.
		/// </summary>
		[EnumMember(Value = "SHIPPED")]
		SHIPPED,

		/// <summary>
		/// Status for orders rejected due to quality issues with products on the floor, or the physical and virtual
		/// inventory do not match.
		/// </summary>
		[EnumMember(Value = "FLOOR_DENIAL")]
		FLOOR_DENIAL,
	}
}
