namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpDelete("/notifications/v1/destinations/{destinationId}")]
	public class DeleteDestinationDeleteRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the destination that you want to delete
		/// </summary>
		[InPath("destinationId")]
		[IsRequired]
		[JsonProperty("destinationId")]
		public string DestinationId { get; set; }
	}
}
