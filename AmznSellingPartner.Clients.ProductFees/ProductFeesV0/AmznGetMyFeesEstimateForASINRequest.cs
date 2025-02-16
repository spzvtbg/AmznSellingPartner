namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/products/fees/v0/items/{Asin}/feesEstimate")]
    public class AmznGetMyFeesEstimateForASINRequest : BaseHttpRequest
    {
        [InBody("body")]
        [IsRequired]
        public GetMyFeesEstimateRequest Body { get; set; }

        /// <summary>
        /// The Amazon Standard Identification Number (ASIN) of the item.
        /// </summary>
        [InPath("Asin")]
        [IsRequired]
        public string Asin { get; set; }
    }
}
