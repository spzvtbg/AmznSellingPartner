namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The type of rich text decorator
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DecoratorType
	{
		/// <summary>
		/// Formatted list item, used in either numbered or bulleted lists, inside the list enclosure
		/// </summary>
		[EnumMember(Value = "LIST_ITEM")]
		LIST_ITEM,

		/// <summary>
		/// Numbered list enclosure
		/// </summary>
		[EnumMember(Value = "LIST_ORDERED")]
		LIST_ORDERED,

		/// <summary>
		/// Bulleted list enclosure
		/// </summary>
		[EnumMember(Value = "LIST_UNORDERED")]
		LIST_UNORDERED,

		/// <summary>
		/// Bold text formatting
		/// </summary>
		[EnumMember(Value = "STYLE_BOLD")]
		STYLE_BOLD,

		/// <summary>
		/// Italic text formatting
		/// </summary>
		[EnumMember(Value = "STYLE_ITALIC")]
		STYLE_ITALIC,

		/// <summary>
		/// New line of text
		/// </summary>
		[EnumMember(Value = "STYLE_LINEBREAK")]
		STYLE_LINEBREAK,

		/// <summary>
		/// Paragraph text formatting
		/// </summary>
		[EnumMember(Value = "STYLE_PARAGRAPH")]
		STYLE_PARAGRAPH,

		/// <summary>
		/// Underline text formatting
		/// </summary>
		[EnumMember(Value = "STYLE_UNDERLINE")]
		STYLE_UNDERLINE,
	}
}
