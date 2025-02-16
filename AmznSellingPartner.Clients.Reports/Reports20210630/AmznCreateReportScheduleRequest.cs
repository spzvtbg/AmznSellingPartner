namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/reports/2021-06-30/schedules")]
    public class AmznCreateReportScheduleRequest : BaseHttpRequest
    {
        /// <summary>
        /// Information required to create the report schedule.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public CreateReportScheduleSpecification Body { get; set; }
    }
}
