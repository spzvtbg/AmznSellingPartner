namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Unit
	{
		/// <summary>
		/// Metric unit of mass equal to one thousandth of a kilogram.
		/// </summary>
		[EnumMember(Value = "GRAM")]
		GRAM,

		/// <summary>
		/// Metric unit of mass.
		/// </summary>
		[EnumMember(Value = "KILOGRAM")]
		KILOGRAM,

		/// <summary>
		/// The imperial unit of weight that is one sixteenth of a pound.
		/// </summary>
		[EnumMember(Value = "OUNCE")]
		OUNCE,

		/// <summary>
		/// The imperial unit of weight.
		/// </summary>
		[EnumMember(Value = "POUND")]
		POUND,

		/// <summary>
		/// Milliliter - Metric unit of volume.
		/// </summary>
		[EnumMember(Value = "ML")]
		ML,

		/// <summary>
		/// Liter - Metric unit of volume.
		/// </summary>
		[EnumMember(Value = "L")]
		L,

		/// <summary>
		/// Fluid Ounce - Imperial unit of volume.
		/// </summary>
		[EnumMember(Value = "FL_OZ")]
		FL_OZ,

		/// <summary>
		/// Gallon - Imperial unit of volume.
		/// </summary>
		[EnumMember(Value = "GAL")]
		GAL,

		/// <summary>
		/// Pint - Imperial unit of volume.
		/// </summary>
		[EnumMember(Value = "PT")]
		PT,

		/// <summary>
		/// Quart - Imperial unit of volume.
		/// </summary>
		[EnumMember(Value = "QT")]
		QT,

		/// <summary>
		/// Cup - Imperial unit of volume.
		/// </summary>
		[EnumMember(Value = "C")]
		C,

		/// <summary>
		/// The imperial unit of length equal to one twelfth of a foot.
		/// </summary>
		[EnumMember(Value = "INCH")]
		INCH,

		/// <summary>
		/// A metric unit of length, equal to one hundredth of a meter.
		/// </summary>
		[EnumMember(Value = "CENTIMETER")]
		CENTIMETER,
	}
}
