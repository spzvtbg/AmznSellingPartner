namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/mfn/v0/eligibleShippingServices")]
    public class AmznGetEligibleShipmentServicesRequest : BaseHttpRequest
    {
        /// <summary>
        /// The request schema for the `GetEligibleShipmentServices` operation.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public GetEligibleShipmentServicesRequest Body { get; set; }
    }
}
