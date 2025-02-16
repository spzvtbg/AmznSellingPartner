namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/inbound/fba/2024-03-20/items/prepDetails")]
    public class AmznSetPrepDetailsRequest : BaseHttpRequest
    {
        /// <summary>
        /// The body of the request to `setPrepDetails`.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public SetPrepDetailsRequest Body { get; set; }
    }
}
