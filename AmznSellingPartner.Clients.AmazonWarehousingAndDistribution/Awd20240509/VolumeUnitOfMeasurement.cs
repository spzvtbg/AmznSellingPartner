namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Unit of measurement for the package volume
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VolumeUnitOfMeasurement
	{
		/// <summary>
		/// Denotes volume measurement in cubic inches
		/// </summary>
		[EnumMember(Value = "CU_IN")]
		CU_IN,

		/// <summary>
		/// Denotes volume measurement in cubic meters
		/// </summary>
		[EnumMember(Value = "CBM")]
		CBM,

		/// <summary>
		/// Denotes volume measurement in cubic centimeters
		/// </summary>
		[EnumMember(Value = "CC")]
		CC,
	}
}
