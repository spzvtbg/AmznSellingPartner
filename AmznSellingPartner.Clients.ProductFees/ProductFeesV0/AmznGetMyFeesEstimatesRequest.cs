namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/products/fees/v0/feesEstimate")]
    public class AmznGetMyFeesEstimatesRequest : BaseHttpRequest
    {
        [InBody("body")]
        [IsRequired]
        public GetMyFeesEstimatesRequest Body { get; set; }
    }
}
