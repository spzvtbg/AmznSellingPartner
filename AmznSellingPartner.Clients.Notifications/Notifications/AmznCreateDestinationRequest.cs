namespace AmznSellingPartner.Clients.Notifications.Notifications
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/notifications/v1/destinations")]
    public class AmznCreateDestinationRequest : BaseHttpRequest
    {
        [InBody("body")]
        [IsRequired]
        public CreateDestinationRequest Body { get; set; }
    }
}
