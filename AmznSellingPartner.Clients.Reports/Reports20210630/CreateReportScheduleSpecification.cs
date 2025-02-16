namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// Information required to create the report schedule.
    /// </summary>
    public class CreateReportScheduleSpecification : BaseClass
    {
        /// <summary>
        /// The report type. Refer to [Report Type Values](https://developer-docs.amazon.com/sp-api/docs/report-type-values)
        /// for more information.
        /// </summary>
        [JsonProperty("reportType")]
        [IsRequired]
        public string ReportType { get; set; }

        /// <summary>
        /// A list of marketplace identifiers for the report schedule.
        /// </summary>
        [JsonProperty("marketplaceIds")]
        [IsRequired]
        [MinItems(1)]
        [MaxItems(25)]
        public List<string> MarketplaceIds { get; set; }

        [JsonProperty("reportOptions")]
        public ReportOptions ReportOptions { get; set; }

        /// <summary>
        /// One of a set of predefined <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> periods that specifies how often a report should be created.
        /// </summary>
        [JsonProperty("period")]
        [IsRequired]
        public Period Period { get; set; }

        /// <summary>
        /// The date and time when the schedule will create its next report, in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> date time format.
        /// </summary>
        [JsonProperty("nextReportCreationTime")]
        public DateTimeValue NextReportCreationTime { get; set; }
    }
}
