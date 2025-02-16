namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/mfn/v0/shipments")]
    public class AmznCreateShipmentRequest : BaseHttpRequest
    {
        /// <summary>
        /// The request schema for the `CreateShipment` operation.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public CreateShipmentRequest Body { get; set; }
    }
}
