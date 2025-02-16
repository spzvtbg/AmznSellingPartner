namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
    using AmznSellingPartner.Clients.HttpAttributes;

    [HttpPost("/replenishment/2022-11-07/sellingPartners/metrics/search")]
    public class AmznGetSellingPartnerMetricsRequest : BaseHttpRequest
    {
        /// <summary>
        /// The request body for the `getSellingPartnerMetrics` operation.
        /// </summary>
        [InBody("body")]
        public GetSellingPartnerMetricsRequest Body { get; set; }
    }
}
