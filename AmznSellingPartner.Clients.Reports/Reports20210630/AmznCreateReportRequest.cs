namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/reports/2021-06-30/reports")]
    public class AmznCreateReportRequest : BaseHttpRequest
    {
        /// <summary>
        /// Information required to create the report.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public CreateReportSpecification Body { get; set; }
    }
}
