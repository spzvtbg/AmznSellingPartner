namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The label format
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LabelFormat
	{
		/// <summary>
		/// Portable Document Format (pdf)
		/// </summary>
		[EnumMember(Value = "PDF")]
		PDF,

		/// <summary>
		/// Portable Network Graphics (png) format
		/// </summary>
		[EnumMember(Value = "PNG")]
		PNG,

		/// <summary>
		/// Zebra Programming Language (zpl) format, 203 dots per inch resolution
		/// </summary>
		[EnumMember(Value = "ZPL203")]
		ZPL203,

		/// <summary>
		/// Zebra Programming Language (zpl) format, 300 dots per inch resolution
		/// </summary>
		[EnumMember(Value = "ZPL300")]
		ZPL300,

		/// <summary>
		/// The default provided by the shipping service
		/// </summary>
		[EnumMember(Value = "ShippingServiceDefault")]
		ShippingServiceDefault,
	}
}
