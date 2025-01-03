namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The relative color scheme of content.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ColorType
	{
		/// <summary>
		/// Dark grey, semi-opaque shaded background for light text overlay box.
		/// </summary>
		[EnumMember(Value = "DARK")]
		DARK,

		/// <summary>
		/// White, semi-opaque shaded background for dark text overlay box.
		/// </summary>
		[EnumMember(Value = "LIGHT")]
		LIGHT,
	}
}
