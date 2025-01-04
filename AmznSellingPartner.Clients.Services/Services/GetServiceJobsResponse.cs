namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	/// <summary>
	/// Response schema for the `getServiceJobs` operation.
	/// </summary>
	public class GetServiceJobsResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `getServiceJobs` operation.
		/// </summary>
		[JsonProperty("payload")]
		public JobListing Payload { get; set; } 

		/// <summary>
		/// An unexpected condition occurred during the `getServiceJobs` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
