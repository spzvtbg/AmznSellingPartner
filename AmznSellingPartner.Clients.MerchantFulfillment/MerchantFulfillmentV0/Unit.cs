namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Unit
	{
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
		/// Fluid ounce - Imperial unit of volume.
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
	}
}
