namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The page type to use to print the labels. Possible values: 'A4_21', 'A4_24', 'A4_24_64x33', 'A4_24_66x35', 'A4
	/// 24_70x36', 'A4_24_70x37', 'A4_24i', 'A4_27', 'A4_40_52x29', 'A4_44_48x25', 'Letter_30'.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ItemLabelPageType
	{
		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "A4_21")]
		A4_21,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "A4_24")]
		A4_24,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "A4_24_64x33")]
		A4_24_64x33,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "A4_24_66x35")]
		A4_24_66x35,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "A4_24_70x36")]
		A4_24_70x36,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "A4_24_70x37")]
		A4_24_70x37,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "A4_24i")]
		A4_24i,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "A4_27")]
		A4_27,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "A4_40_52x29")]
		A4_40_52x29,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "A4_44_48x25")]
		A4_44_48x25,

		/// <summary>
		/// -
		/// </summary>
		[EnumMember(Value = "Letter_30")]
		Letter_30,
	}
}
