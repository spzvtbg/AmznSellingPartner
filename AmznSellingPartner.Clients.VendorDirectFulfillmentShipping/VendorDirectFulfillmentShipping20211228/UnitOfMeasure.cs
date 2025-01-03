namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum UnitOfMeasure
	{
		/// <summary>
		/// Inches
		/// </summary>
		[EnumMember(Value = "IN")]
		IN,

		/// <summary>
		/// Centimeters
		/// </summary>
		[EnumMember(Value = "CM")]
		CM,

		/// <summary>
		/// Kilogram
		/// </summary>
		[EnumMember(Value = "KG")]
		KG,

		/// <summary>
		/// Pounds (Libra for Latin).
		/// </summary>
		[EnumMember(Value = "LB")]
		LB,
	}
}
