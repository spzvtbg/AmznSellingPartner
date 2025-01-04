namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A simple object containing the name of the template.
	/// </summary>
	public class MessagingAction : BaseClass
	{
		/// <summary>
		/// The name of the template.
		/// </summary>
		[JsonProperty("name")]
		[IsRequired]
		public string Name { get; set; } 
	}
}
