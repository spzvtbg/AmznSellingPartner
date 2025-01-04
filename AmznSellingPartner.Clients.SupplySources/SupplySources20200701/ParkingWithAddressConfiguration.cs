namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The parking configuration with the address.
	/// </summary>
	public class ParkingWithAddressConfiguration : BaseClass
	{
		/// <summary>
		/// The address of the parking location.
		/// </summary>
		[JsonProperty("address")]
		public Address Address { get; set; } 
	}
}
