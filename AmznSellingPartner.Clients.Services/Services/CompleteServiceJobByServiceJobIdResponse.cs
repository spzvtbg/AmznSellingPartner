namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	/// <summary>
	/// Response schema for the `completeServiceJobByServiceJobId` operation.
	/// </summary>
	public class CompleteServiceJobByServiceJobIdResponse : BaseClass
	{
		/// <summary>
		/// Encountered errors for the `completeServiceJobByServiceJobId` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
