namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using Newtonsoft.Json;

	/// <summary>
	/// An event filter to customize your subscription to send notifications for only the specified `marketp
	/// laceId`s.
	/// </summary>
	public class MarketplaceFilter : BaseClass
	{
		[JsonProperty("marketplaceIds")]
		public MarketplaceIds MarketplaceIds { get; set; } 
	}
}
