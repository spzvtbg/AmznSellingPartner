namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the createConfirmDeliveryDetails operation.
	/// </summary>
	public class CreateConfirmDeliveryDetailsResponse : BaseClass
	{
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
