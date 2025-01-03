namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The file format of the document.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DocumentFormat
	{
		/// <summary>
		/// The Portable Document Format (PDF) file format. Used to present documents, including text formatting and image
		/// , in a manner independent of application software, hardware, and operating systems.
		/// </summary>
		[EnumMember(Value = "PDF")]
		PDF,

		/// <summary>
		/// Portable Network Graphics (PNG) is a raster-graphics file format that supports lossless data compression.
		/// </summary>
		[EnumMember(Value = "PNG")]
		PNG,

		/// <summary>
		/// Zebra Programming Language (ZPL) format is from Zebra Technologies. It's used primarily for labeling applicati
		/// ns and can only be used with ZPL compatible printers.
		/// </summary>
		[EnumMember(Value = "ZPL")]
		ZPL,
	}
}
