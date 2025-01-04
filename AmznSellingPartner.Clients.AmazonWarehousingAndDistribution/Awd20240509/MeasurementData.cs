namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Package weight and dimension.
	/// </summary>
	public class MeasurementData : BaseClass
	{
		/// <summary>
		/// Dimensions of the package. Dimensions are required when creating an inbound or outbound order.
		/// </summary>
		[JsonProperty("dimensions")]
		public PackageDimensions Dimensions { get; set; }

		/// <summary>
		/// Volume of the package.
		/// </summary>
		[JsonProperty("volume")]
		public PackageVolume Volume { get; set; }

		/// <summary>
		/// Weight of the package.
		/// </summary>
		[JsonProperty("weight")]
		[IsRequired]
		public PackageWeight Weight { get; set; }
	}
}
