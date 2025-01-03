namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum UnitOfMeasure
	{
		/// <summary>
		/// Priced per Pound
		/// </summary>
		[EnumMember(Value = "POUNDS")]
		POUNDS,

		/// <summary>
		/// Priced per Ounce
		/// </summary>
		[EnumMember(Value = "OUNCES")]
		OUNCES,

		/// <summary>
		/// Priced per Gram
		/// </summary>
		[EnumMember(Value = "GRAMS")]
		GRAMS,

		/// <summary>
		/// Priced per Kilogram
		/// </summary>
		[EnumMember(Value = "KILOGRAMS")]
		KILOGRAMS,

		/// <summary>
		/// Packing of individual items into a case
		/// </summary>
		[EnumMember(Value = "Cases")]
		Cases,

		/// <summary>
		/// Individual items
		/// </summary>
		[EnumMember(Value = "Eaches")]
		Eaches,
	}
}
