namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the createUnexpectedProblem operation.
	/// </summary>
	public class CreateUnexpectedProblemResponse : BaseClass
	{
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
