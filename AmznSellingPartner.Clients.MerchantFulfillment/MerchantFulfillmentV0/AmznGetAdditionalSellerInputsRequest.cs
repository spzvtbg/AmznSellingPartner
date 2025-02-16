namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/mfn/v0/additionalSellerInputs")]
    public class AmznGetAdditionalSellerInputsRequest : BaseHttpRequest
    {
        /// <summary>
        /// The request schema for the `GetAdditionalSellerInputs` operation.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public GetAdditionalSellerInputsRequest Body { get; set; }
    }
}
