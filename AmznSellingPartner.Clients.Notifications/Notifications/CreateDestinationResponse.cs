namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the createDestination operation.
	/// </summary>
	public class CreateDestinationResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `createDestination` operation.
		/// </summary>
		[JsonProperty("payload")]
		public Destination Payload { get; set; } 

		/// <summary>
		/// One or more unexpected errors occurred during the `createDestination` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
