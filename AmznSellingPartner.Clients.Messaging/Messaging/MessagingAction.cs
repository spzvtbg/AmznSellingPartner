namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A simple object containing the name of the template
	/// </summary>
	public class MessagingAction : BaseClass
	{
		/// <summary>
		/// The name of the template
		/// </summary>
		[IsRequired]
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
