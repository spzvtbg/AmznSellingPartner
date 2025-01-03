namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ConditionType
	{
		/// <summary>
		/// New.
		/// </summary>
		[EnumMember(Value = "new_new")]
		new_new,

		/// <summary>
		/// New - Open Box.
		/// </summary>
		[EnumMember(Value = "new_open_box")]
		new_open_box,

		/// <summary>
		/// New - OEM.
		/// </summary>
		[EnumMember(Value = "new_oem")]
		new_oem,

		/// <summary>
		/// Refurbished.
		/// </summary>
		[EnumMember(Value = "refurbished_refurbished")]
		refurbished_refurbished,

		/// <summary>
		/// Used - Like New.
		/// </summary>
		[EnumMember(Value = "used_like_new")]
		used_like_new,

		/// <summary>
		/// Used - Very Good.
		/// </summary>
		[EnumMember(Value = "used_very_good")]
		used_very_good,

		/// <summary>
		/// Used - Good.
		/// </summary>
		[EnumMember(Value = "used_good")]
		used_good,

		/// <summary>
		/// Used - Acceptable.
		/// </summary>
		[EnumMember(Value = "used_acceptable")]
		used_acceptable,

		/// <summary>
		/// Collectible - Like New.
		/// </summary>
		[EnumMember(Value = "collectible_like_new")]
		collectible_like_new,

		/// <summary>
		/// Collectible - Very Good.
		/// </summary>
		[EnumMember(Value = "collectible_very_good")]
		collectible_very_good,

		/// <summary>
		/// Collectible - Good.
		/// </summary>
		[EnumMember(Value = "collectible_good")]
		collectible_good,

		/// <summary>
		/// Collectible - Acceptable.
		/// </summary>
		[EnumMember(Value = "collectible_acceptable")]
		collectible_acceptable,

		/// <summary>
		/// Club.
		/// </summary>
		[EnumMember(Value = "club_club")]
		club_club,
	}
}
