namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/notifications/v1/destinations")]
	public class CreateDestinationPostRequest : BaseHttpRequest
	{
		[InBody("body")]
		[IsRequired]
		public CreateDestinationRequest Body { get; set; } 
	}
}
