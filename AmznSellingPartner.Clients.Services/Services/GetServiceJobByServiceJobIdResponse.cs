namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getServiceJobByServiceJobId` operation.
	/// </summary>
	public class GetServiceJobByServiceJobIdResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `getServiceJobByServiceJobId` operation.
		/// </summary>
		[JsonProperty("payload")]
		public ServiceJob Payload { get; set; } 

		/// <summary>
		/// An unexpected condition occurred during the `getServiceJobByServiceJobId` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
