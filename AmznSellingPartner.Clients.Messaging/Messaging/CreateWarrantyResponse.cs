namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the createWarranty operation
	/// </summary>
	public class CreateWarrantyResponse : BaseClass
	{
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
