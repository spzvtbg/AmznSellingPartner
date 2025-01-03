namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The A+ Content document type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ContentType
	{
		/// <summary>
		/// A+ Content published through the A+ Content Manager in Seller Central.
		/// </summary>
		[EnumMember(Value = "EBC")]
		EBC,

		/// <summary>
		/// A+ Content published through the A+ Content Manager in Vendor Central.
		/// </summary>
		[EnumMember(Value = "EMC")]
		EMC,
	}
}
