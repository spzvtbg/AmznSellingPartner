namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	/// <summary>
	/// Location identifier
	/// </summary>
	public class Location : BaseClass
	{
		/// <summary>
		/// Type of location identification
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// Location code
		/// </summary>
		[JsonProperty("locationCode")]
		public string LocationCode { get; set; }

		/// <summary>
		/// The two digit country code
		/// In ISO 3166-1 alpha-2 format
		/// </summary>
		[JsonProperty("countryCode")]
		public string CountryCode { get; set; }
	}
}
