namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpDelete("/reports/2021-06-30/schedules/{reportScheduleId}")]
    public class AmznCancelReportScheduleRequest : BaseHttpRequest
    {
        /// <summary>
        /// The identifier for the report schedule. This identifier is unique only in combination with
        /// a seller ID.
        /// </summary>
        [InPath("reportScheduleId")]
        [IsRequired]
        public string ReportScheduleId { get; set; }
    }
}
