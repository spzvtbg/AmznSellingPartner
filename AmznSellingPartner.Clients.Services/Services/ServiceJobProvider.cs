namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Information about the service job provider.
	/// </summary>
	public class ServiceJobProvider : BaseClass
	{
		/// <summary>
		/// The identifier of the service job provider.
		/// </summary>
		[Pattern("^[A-Z0-9]*")]
		[JsonProperty("serviceJobProviderId")]
		public string ServiceJobProviderId { get; set; }
	}
}
