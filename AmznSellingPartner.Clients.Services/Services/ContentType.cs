namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ContentType
	{
		/// <summary>
		/// To be uploaded POA is of type image/tiff.
		/// </summary>
		[EnumMember(Value = "TIFF")]
		TIFF,

		/// <summary>
		/// To be uploaded POA is of type image/jpg.
		/// </summary>
		[EnumMember(Value = "JPG")]
		JPG,

		/// <summary>
		/// To be uploaded POA is of type image/png.
		/// </summary>
		[EnumMember(Value = "PNG")]
		PNG,

		/// <summary>
		/// To be uploaded POA is of type image/jpeg.
		/// </summary>
		[EnumMember(Value = "JPEG")]
		JPEG,

		/// <summary>
		/// To be uploaded POA is of type image/gif.
		/// </summary>
		[EnumMember(Value = "GIF")]
		GIF,

		/// <summary>
		/// To be uploaded POA is of type application/pdf.
		/// </summary>
		[EnumMember(Value = "PDF")]
		PDF,
	}
}
