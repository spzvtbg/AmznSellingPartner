namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ItemClassification
	{
		/// <summary>
		/// Represents a standard standalone or a variation child item in the Amazon catalog.
		/// </summary>
		[EnumMember(Value = "BASE_PRODUCT")]
		BASE_PRODUCT,

		/// <summary>
		/// Represents an item in the Amazon catalog that is not `BASE_PRODUCT`, `PRODUCT_BUNDLE`, or `VARIATION_PARENT`.
		/// </summary>
		[EnumMember(Value = "OTHER")]
		OTHER,

		/// <summary>
		/// Represents a parent Amazon catalog item representing a bundle of items.
		/// </summary>
		[EnumMember(Value = "PRODUCT_BUNDLE")]
		PRODUCT_BUNDLE,

		/// <summary>
		/// Represents a parent Amazon catalog item grouping child items into a variation family.
		/// </summary>
		[EnumMember(Value = "VARIATION_PARENT")]
		VARIATION_PARENT,
	}
}
