namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The preparation category for shipping an item to Amazon's fulfillment network.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PrepCategory
	{
		/// <summary>
		/// Displays potentially offensive material such as profanity or nudity.
		/// </summary>
		[EnumMember(Value = "ADULT")]
		ADULT,

		/// <summary>
		/// Made for a child aged three years or younger, packaging with cutouts greater than one square
		/// inch.
		/// </summary>
		[EnumMember(Value = "BABY")]
		BABY,

		/// <summary>
		/// A prep type has been defined by the Fulfillment Center. This value is provided by Amazon and
		/// cannot be used as an input.
		/// </summary>
		[EnumMember(Value = "FC_PROVIDED")]
		FC_PROVIDED,

		/// <summary>
		/// Glass or otherwise fragile, or a liquid in a glass container.
		/// </summary>
		[EnumMember(Value = "FRAGILE")]
		FRAGILE,

		/// <summary>
		/// Made of powder, pellets, or granular material.
		/// </summary>
		[EnumMember(Value = "GRANULAR")]
		GRANULAR,

		/// <summary>
		/// Made of cloth or fabric and intended to be put on a hanger.
		/// </summary>
		[EnumMember(Value = "HANGER")]
		HANGER,

		/// <summary>
		/// Liquid or viscous without a double seal.
		/// </summary>
		[EnumMember(Value = "LIQUID")]
		LIQUID,

		/// <summary>
		/// In packaging that has a perforated opening.
		/// </summary>
		[EnumMember(Value = "PERFORATED")]
		PERFORATED,

		/// <summary>
		/// Multiple items that are sold as one unit.
		/// </summary>
		[EnumMember(Value = "SET")]
		SET,

		/// <summary>
		/// Sharp and easily exposed, not already contained in protective packaging.
		/// </summary>
		[EnumMember(Value = "SHARP")]
		SHARP,

		/// <summary>
		/// Longest side less than 2 1/8 inches (width of a credit card).
		/// </summary>
		[EnumMember(Value = "SMALL")]
		SMALL,

		/// <summary>
		/// Made of cloth or fabric that could be damaged by dirt, dust, moisture, or liquid.
		/// </summary>
		[EnumMember(Value = "TEXTILE")]
		TEXTILE,

		/// <summary>
		/// An unknown prep category was found and needs to be updated. This value is provided by Amazon
		/// and cannot be used as an input.
		/// </summary>
		[EnumMember(Value = "UNKNOWN")]
		UNKNOWN,

		/// <summary>
		/// Does not require prep.
		/// </summary>
		[EnumMember(Value = "NONE")]
		NONE,
	}
}
