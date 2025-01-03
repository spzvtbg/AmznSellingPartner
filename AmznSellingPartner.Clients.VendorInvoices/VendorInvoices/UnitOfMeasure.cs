namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum UnitOfMeasure
	{
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

		/// <summary>
		/// Weight in Pound
		/// </summary>
		[EnumMember(Value = "POUNDS")]
		POUNDS,

		/// <summary>
		/// Weight in Ounce
		/// </summary>
		[EnumMember(Value = "OUNCES")]
		OUNCES,

		/// <summary>
		/// Weight in Gram
		/// </summary>
		[EnumMember(Value = "GRAMS")]
		GRAMS,

		/// <summary>
		/// Weight in Kilogram
		/// </summary>
		[EnumMember(Value = "KILOGRAMS")]
		KILOGRAMS,
	}
}
