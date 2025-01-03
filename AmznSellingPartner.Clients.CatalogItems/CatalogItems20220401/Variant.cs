namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Variant
	{
		/// <summary>
		/// Main image for the item
		/// </summary>
		[EnumMember(Value = "MAIN")]
		MAIN,

		/// <summary>
		/// Other image #1 for the item
		/// </summary>
		[EnumMember(Value = "PT01")]
		PT01,

		/// <summary>
		/// Other image #2 for the item
		/// </summary>
		[EnumMember(Value = "PT02")]
		PT02,

		/// <summary>
		/// Other image #3 for the item
		/// </summary>
		[EnumMember(Value = "PT03")]
		PT03,

		/// <summary>
		/// Other image #4 for the item
		/// </summary>
		[EnumMember(Value = "PT04")]
		PT04,

		/// <summary>
		/// Other image #5 for the item
		/// </summary>
		[EnumMember(Value = "PT05")]
		PT05,

		/// <summary>
		/// Other image #6 for the item
		/// </summary>
		[EnumMember(Value = "PT06")]
		PT06,

		/// <summary>
		/// Other image #7 for the item
		/// </summary>
		[EnumMember(Value = "PT07")]
		PT07,

		/// <summary>
		/// Other image #8 for the item
		/// </summary>
		[EnumMember(Value = "PT08")]
		PT08,

		/// <summary>
		/// Swatch image for the item
		/// </summary>
		[EnumMember(Value = "SWCH")]
		SWCH,
	}
}
