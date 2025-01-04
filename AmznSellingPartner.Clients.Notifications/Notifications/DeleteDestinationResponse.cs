namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `deleteDestination` operation.
	/// </summary>
	public class DeleteDestinationResponse : BaseClass
	{
		/// <summary>
		/// One or more unexpected errors occurred during the `deleteDestination` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
