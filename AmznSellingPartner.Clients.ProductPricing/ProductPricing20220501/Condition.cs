namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The condition of the item
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Condition
	{
		/// <summary>
		/// New
		/// </summary>
		[EnumMember(Value = "New")]
		New,

		/// <summary>
		/// Used
		/// </summary>
		[EnumMember(Value = "Used")]
		Used,

		/// <summary>
		/// Collectible
		/// </summary>
		[EnumMember(Value = "Collectible")]
		Collectible,

		/// <summary>
		/// Refurbished
		/// </summary>
		[EnumMember(Value = "Refurbished")]
		Refurbished,

		/// <summary>
		/// Club
		/// </summary>
		[EnumMember(Value = "Club")]
		Club,
	}
}
