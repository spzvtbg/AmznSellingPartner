namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/notifications/v1/destinations/{destinationId}")]
	public class GetDestinationGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier generated when you created the destination.
		/// </summary>
		[InPath("destinationId")]
		[IsRequired]
		[JsonProperty("destinationId")]
		public string DestinationId { get; set; }
	}
}
