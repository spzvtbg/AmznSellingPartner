namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The file type for a label.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FileType
	{
		/// <summary>
		/// A Portable Document Format (pdf) file.
		/// </summary>
		[EnumMember(Value = "application/pdf")]
		Application_pdf,

		/// <summary>
		/// A Zebra Programming Language (zpl) file.
		/// </summary>
		[EnumMember(Value = "application/zpl")]
		Application_zpl,

		/// <summary>
		/// A Portable Network Graphics (png) file.
		/// </summary>
		[EnumMember(Value = "image/png")]
		Image_png,
	}
}
