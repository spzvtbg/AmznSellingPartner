namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Type of distribution packages
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DistributionPackageType
	{
		/// <summary>
		/// Package type `CASE`
		/// </summary>
		[EnumMember(Value = "CASE")]
		CASE,

		/// <summary>
		/// Package type `PALLET`
		/// Currently, the `PALLET` package type is not supported
		/// </summary>
		[EnumMember(Value = "PALLET")]
		PALLET,
	}
}
