namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	/// <summary>
	/// The resource that performs or performed appointment fulfillment
	/// </summary>
	public class AppointmentResource : BaseClass
	{
		/// <summary>
		/// The resource identifier
		/// </summary>
		[JsonProperty("resourceId")]
		public string ResourceId { get; set; }
	}
}
