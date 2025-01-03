namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Represents the volume of the package with a unit of measurement
	/// </summary>
	public class PackageVolume : BaseClass
	{
		/// <summary>
		/// Unit of measurement for the package volume
		/// </summary>
		[IsRequired]
		[JsonProperty("unitOfMeasurement")]
		public VolumeUnitOfMeasurement UnitOfMeasurement { get; set; }

		/// <summary>
		/// The package volume value
		/// </summary>
		[IsRequired]
		[JsonProperty("volume")]
		public double Volume { get; set; }
	}
}
