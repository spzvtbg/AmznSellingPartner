namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum SubCondition
	{
		/// <summary>
		/// New
		/// </summary>
		[EnumMember(Value = "New")]
		New,

		/// <summary>
		/// Mint
		/// </summary>
		[EnumMember(Value = "Mint")]
		Mint,

		/// <summary>
		/// VeryGood
		/// </summary>
		[EnumMember(Value = "VeryGood")]
		VeryGood,

		/// <summary>
		/// Good
		/// </summary>
		[EnumMember(Value = "Good")]
		Good,

		/// <summary>
		/// Acceptable
		/// </summary>
		[EnumMember(Value = "Acceptable")]
		Acceptable,

		/// <summary>
		/// Poor
		/// </summary>
		[EnumMember(Value = "Poor")]
		Poor,

		/// <summary>
		/// Club
		/// </summary>
		[EnumMember(Value = "Club")]
		Club,

		/// <summary>
		/// OEM
		/// </summary>
		[EnumMember(Value = "OEM")]
		OEM,

		/// <summary>
		/// Warranty
		/// </summary>
		[EnumMember(Value = "Warranty")]
		Warranty,

		/// <summary>
		/// RefurbishedWarranty
		/// </summary>
		[EnumMember(Value = "RefurbishedWarranty")]
		RefurbishedWarranty,

		/// <summary>
		/// Refurbished
		/// </summary>
		[EnumMember(Value = "Refurbished")]
		Refurbished,

		/// <summary>
		/// OpenBox
		/// </summary>
		[EnumMember(Value = "OpenBox")]
		OpenBox,

		/// <summary>
		/// Other
		/// </summary>
		[EnumMember(Value = "Other")]
		Other,
	}
}
