namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	/// <summary>
	/// Information about the location of the service job.
	/// </summary>
	public class ServiceLocation : BaseClass
	{
		/// <summary>
		/// The location of the service job.
		/// </summary>
		[JsonProperty("serviceLocationType")]
		public ServiceLocationType ServiceLocationType { get; set; } 

		/// <summary>
		/// The shipping address for the service job.
		/// </summary>
		[JsonProperty("address")]
		public Address Address { get; set; } 
	}
}
