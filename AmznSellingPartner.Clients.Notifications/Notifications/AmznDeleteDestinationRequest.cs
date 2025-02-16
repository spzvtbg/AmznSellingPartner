namespace AmznSellingPartner.Clients.Notifications.Notifications
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpDelete("/notifications/v1/destinations/{destinationId}")]
    public class AmznDeleteDestinationRequest : BaseHttpRequest
    {
        /// <summary>
        /// The identifier for the destination that you want to delete.
        /// </summary>
        [InPath("destinationId")]
        [IsRequired]
        public string DestinationId { get; set; }
    }
}
