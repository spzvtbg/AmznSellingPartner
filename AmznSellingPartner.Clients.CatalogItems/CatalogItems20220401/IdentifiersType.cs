namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
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
		/// Stock Keeping Unit, a seller-specified identifier for an Amazon listing. **Note:** Must be accompanied by `sel
		/// erId`.
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
