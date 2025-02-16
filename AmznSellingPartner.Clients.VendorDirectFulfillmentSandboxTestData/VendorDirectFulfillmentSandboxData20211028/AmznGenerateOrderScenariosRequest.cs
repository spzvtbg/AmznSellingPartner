namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/vendor/directFulfillment/sandbox/2021-10-28/orders")]
    public class AmznGenerateOrderScenariosRequest : BaseHttpRequest
    {
        /// <summary>
        /// The request payload containing parameters for generating test order data scenarios.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public GenerateOrderScenarioRequest Body { get; set; }
    }
}
