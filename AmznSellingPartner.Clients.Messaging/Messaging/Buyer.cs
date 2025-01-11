namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using Newtonsoft.Json;

	public class Buyer : BaseClass
	{
		/// <summary>
		/// The buyer's language of preference, indicated with a locale-specific language tag. Examples:
		/// "en-US", "zh-CN", and "en-GB".
		/// </summary>
		[JsonProperty("locale")]
		public string Locale { get; set; } 
	}
}
