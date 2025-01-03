namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum IdentifiersType
	{
		/// <summary>
		/// Amazon Standard Identification Number.
		/// </summary>
		[EnumMember(Value = "ASIN")]
		ASIN,

		/// <summary>
		/// European Article Number.
		/// </summary>
		[EnumMember(Value = "EAN")]
		EAN,

		/// <summary>
		/// Fulfillment Network Stock Keeping Unit.
		/// </summary>
		[EnumMember(Value = "FNSKU")]
		FNSKU,

		/// <summary>
		/// Global Trade Item Number.
		/// </summary>
		[EnumMember(Value = "GTIN")]
		GTIN,

		/// <summary>
		/// International Standard Book Number.
		/// </summary>
		[EnumMember(Value = "ISBN")]
		ISBN,

		/// <summary>
		/// Japanese Article Number.
		/// </summary>
		[EnumMember(Value = "JAN")]
		JAN,

		/// <summary>
		/// Minsan Code.
		/// </summary>
		[EnumMember(Value = "MINSAN")]
		MINSAN,

		/// <summary>
		/// Stock Keeping Unit (SKU): A seller-specified identifier for an Amazon listing.
		/// </summary>
		[EnumMember(Value = "SKU")]
		SKU,

		/// <summary>
		/// Universal Product Code.
		/// </summary>
		[EnumMember(Value = "UPC")]
		UPC,
	}
}
