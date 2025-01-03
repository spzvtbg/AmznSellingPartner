namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// Defines the latitude and longitude of the access point.
	/// </summary>
	public class Geocode : BaseClass
	{
		/// <summary>
		/// The latitude of access point.
		/// </summary>
		[JsonProperty("latitude")]
		public string Latitude { get; set; }

		/// <summary>
		/// The longitude of access point.
		/// </summary>
		[JsonProperty("longitude")]
		public string Longitude { get; set; }
	}
}
