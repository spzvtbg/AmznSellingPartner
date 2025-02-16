namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
    using AmznSellingPartner.Clients.HttpAttributes;

    [HttpPost("/replenishment/2022-11-07/offers/metrics/search")]
    public class AmznListOfferMetricsRequest : BaseHttpRequest
    {
        /// <summary>
        /// The request body for the `listOfferMetrics` operation.
        /// </summary>
        [InBody("body")]
        public ListOfferMetricsRequest Body { get; set; }
    }
}
