namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// This field represents weight unit of measure of items that are ordered by cases and supporting
	/// priced by weight.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NetCostUnitOfMeasure
	{
		/// <summary>
		/// Priced per Pound.
		/// </summary>
		[EnumMember(Value = "POUNDS")]
		POUNDS,

		/// <summary>
		/// Priced per Ounce.
		/// </summary>
		[EnumMember(Value = "OUNCES")]
		OUNCES,

		/// <summary>
		/// Priced per Gram.
		/// </summary>
		[EnumMember(Value = "GRAMS")]
		GRAMS,

		/// <summary>
		/// Priced per Kilogram.
		/// </summary>
		[EnumMember(Value = "KILOGRAMS")]
		KILOGRAMS,
	}
}
