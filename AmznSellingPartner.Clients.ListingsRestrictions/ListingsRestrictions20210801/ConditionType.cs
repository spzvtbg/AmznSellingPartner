namespace AmznSellingPartner.Clients.ListingsRestrictions.ListingsRestrictions20210801
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ConditionType
	{
		/// <summary>
		/// New
		/// </summary>
		[EnumMember(Value = "new_new")]
		New_new,

		/// <summary>
		/// New - Open Box.
		/// </summary>
		[EnumMember(Value = "new_open_box")]
		New_open_box,

		/// <summary>
		/// New - OEM.
		/// </summary>
		[EnumMember(Value = "new_oem")]
		New_oem,

		/// <summary>
		/// Refurbished
		/// </summary>
		[EnumMember(Value = "refurbished_refurbished")]
		Refurbished_refurbished,

		/// <summary>
		/// Used - Like New.
		/// </summary>
		[EnumMember(Value = "used_like_new")]
		Used_like_new,

		/// <summary>
		/// Used - Very Good.
		/// </summary>
		[EnumMember(Value = "used_very_good")]
		Used_very_good,

		/// <summary>
		/// Used - Good.
		/// </summary>
		[EnumMember(Value = "used_good")]
		Used_good,

		/// <summary>
		/// Used - Acceptable.
		/// </summary>
		[EnumMember(Value = "used_acceptable")]
		Used_acceptable,

		/// <summary>
		/// Collectible - Like New.
		/// </summary>
		[EnumMember(Value = "collectible_like_new")]
		Collectible_like_new,

		/// <summary>
		/// Collectible - Very Good.
		/// </summary>
		[EnumMember(Value = "collectible_very_good")]
		Collectible_very_good,

		/// <summary>
		/// Collectible - Good.
		/// </summary>
		[EnumMember(Value = "collectible_good")]
		Collectible_good,

		/// <summary>
		/// Collectible - Acceptable.
		/// </summary>
		[EnumMember(Value = "collectible_acceptable")]
		Collectible_acceptable,

		/// <summary>
		/// Club
		/// </summary>
		[EnumMember(Value = "club_club")]
		Club_club,
	}
}
