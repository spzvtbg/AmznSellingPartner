namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Unit of measurement for the package weight.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum WeightUnitOfMeasurement
	{
		/// <summary>
		/// Denotes weight measurement in pounds.
		/// </summary>
		[EnumMember(Value = "POUNDS")]
		POUNDS,

		/// <summary>
		/// Denotes weight measurement in kilograms.
		/// </summary>
		[EnumMember(Value = "KILOGRAMS")]
		KILOGRAMS,
	}
}
