namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The curbside pickup configuration of a supply source
	/// </summary>
	public class CurbsidePickupConfiguration : BaseClass
	{
		/// <summary>
		/// When true, curbside pickup is supported by the supply source
		/// </summary>
		[JsonProperty("isSupported")]
		public bool IsSupported { get; set; }

		/// <summary>
		/// The operational configuration for the curbside pickup configuration
		/// </summary>
		[JsonProperty("operationalConfiguration")]
		public OperationalConfiguration OperationalConfiguration { get; set; }

		/// <summary>
		/// The parking configuration for curbside pickup with address for customers to use
		/// </summary>
		[JsonProperty("parkingWithAddressConfiguration")]
		public ParkingWithAddressConfiguration ParkingWithAddressConfiguration { get; set; }
	}
}
