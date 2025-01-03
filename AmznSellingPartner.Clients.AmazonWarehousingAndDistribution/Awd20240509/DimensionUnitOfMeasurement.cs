namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Unit of measurement for package dimensions
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DimensionUnitOfMeasurement
	{
		/// <summary>
		/// Denotes package dimensions in inches
		/// </summary>
		[EnumMember(Value = "INCHES")]
		INCHES,

		/// <summary>
		/// Denotes package dimensions in centimeters
		/// </summary>
		[EnumMember(Value = "CENTIMETERS")]
		CENTIMETERS,
	}
}
