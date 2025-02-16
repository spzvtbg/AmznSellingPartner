namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    [HttpGet("/reports/2021-06-30/schedules")]
    public class AmznGetReportSchedulesRequest : BaseHttpRequest
    {
        /// <summary>
        /// A list of report types used to filter report schedules. Refer to [Report Type Values](https://developer-docs.amazon.com/sp-api/docs/report-type-values)
        /// for more information.
        /// </summary>
        [InQuery("reportTypes")]
        [IsRequired]
        [MinItems(1)]
        [MaxItems(10)]
        public CsvValue<string> ReportTypes { get; set; }
    }
}
