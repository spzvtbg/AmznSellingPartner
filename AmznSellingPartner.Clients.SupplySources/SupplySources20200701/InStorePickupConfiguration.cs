namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The in-store pickup configuration of a supply source.
	/// </summary>
	public class InStorePickupConfiguration : BaseClass
	{
		/// <summary>
		/// When true, in-store pickup is supported by the supply source (default: `isSupported` value in `Picku
		/// pChannel`).
		/// </summary>
		[JsonProperty("isSupported")]
		public bool IsSupported { get; set; }

		/// <summary>
		/// The parking configuration for in-store pickup.
		/// </summary>
		[JsonProperty("parkingConfiguration")]
		public ParkingConfiguration ParkingConfiguration { get; set; }
	}
}
