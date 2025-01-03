namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the createConfirmServiceDetails operation.
	/// </summary>
	public class CreateConfirmServiceDetailsResponse : BaseClass
	{
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
