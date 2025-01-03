namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Unit of measurement for the inventory.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum InventoryUnitOfMeasurement
	{
		/// <summary>
		/// Measures a discrete amount of product units.
		/// </summary>
		[EnumMember(Value = "PRODUCT_UNITS")]
		PRODUCT_UNITS,

		/// <summary>
		/// Measures a discrete amount of cases.
		/// </summary>
		[EnumMember(Value = "CASES")]
		CASES,

		/// <summary>
		/// Measures a discrete amount of pallets.
		/// </summary>
		[EnumMember(Value = "PALLETS")]
		PALLETS,
	}
}
