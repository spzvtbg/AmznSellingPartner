namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using Newtonsoft.Json;

	/// <summary>
	/// Additional options to control the feed. These vary by feed type.
	/// </summary>
	public class FeedOptions : BaseClass
	{
		[JsonProperty("AdditionalValue")]
		public string AdditionalValue { get; set; }
	}
}
