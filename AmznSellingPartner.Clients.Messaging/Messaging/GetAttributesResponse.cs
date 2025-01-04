namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the GetAttributes operation.
	/// </summary>
	public class GetAttributesResponse : BaseClass
	{
		/// <summary>
		/// The list of attributes related to the buyer.
		/// </summary>
		[JsonProperty("buyer")]
		public Buyer Buyer { get; set; } 

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
