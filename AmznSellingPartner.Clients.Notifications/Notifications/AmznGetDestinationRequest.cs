namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/notifications/v1/destinations/{destinationId}")]
	public class AmznGetDestinationRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier generated when you created the destination.
		/// </summary>
		[InPath("destinationId")]
		[IsRequired]
		public string DestinationId { get; set; } 
	}
}
