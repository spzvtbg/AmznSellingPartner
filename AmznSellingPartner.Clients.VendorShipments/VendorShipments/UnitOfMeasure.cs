namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
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
		[EnumMember(Value = "In")]
		In,

		/// <summary>
		/// Feet
		/// </summary>
		[EnumMember(Value = "Ft")]
		Ft,

		/// <summary>
		/// Meters
		/// </summary>
		[EnumMember(Value = "Meter")]
		Meter,

		/// <summary>
		/// Yards
		/// </summary>
		[EnumMember(Value = "Yard")]
		Yard,

		/// <summary>
		/// Cubic feet.
		/// </summary>
		[EnumMember(Value = "CuFt")]
		CuFt,

		/// <summary>
		/// Cubic inches.
		/// </summary>
		[EnumMember(Value = "CuIn")]
		CuIn,

		/// <summary>
		/// Cubic meter.
		/// </summary>
		[EnumMember(Value = "CuM")]
		CuM,

		/// <summary>
		/// Cubic yard.
		/// </summary>
		[EnumMember(Value = "CuY")]
		CuY,

		/// <summary>
		/// Grams
		/// </summary>
		[EnumMember(Value = "G")]
		G,

		/// <summary>
		/// Kilograms
		/// </summary>
		[EnumMember(Value = "Kg")]
		Kg,

		/// <summary>
		/// Ounces
		/// </summary>
		[EnumMember(Value = "Oz")]
		Oz,

		/// <summary>
		/// Pounds
		/// </summary>
		[EnumMember(Value = "Lb")]
		Lb,

		/// <summary>
		/// Packing of individual items into a case.
		/// </summary>
		[EnumMember(Value = "Cases")]
		Cases,

		/// <summary>
		/// Individual items.
		/// </summary>
		[EnumMember(Value = "Eaches")]
		Eaches,

		/// <summary>
		/// The weight is measured in pounds.
		/// </summary>
		[EnumMember(Value = "POUNDS")]
		POUNDS,

		/// <summary>
		/// The weight is measured in ounces.
		/// </summary>
		[EnumMember(Value = "OUNCES")]
		OUNCES,

		/// <summary>
		/// The weight is measured in grams.
		/// </summary>
		[EnumMember(Value = "GRAMS")]
		GRAMS,

		/// <summary>
		/// The weight is measured in kilograms.
		/// </summary>
		[EnumMember(Value = "KILOGRAMS")]
		KILOGRAMS,
	}
}
